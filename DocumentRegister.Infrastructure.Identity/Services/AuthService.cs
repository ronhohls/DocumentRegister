﻿using DocumentRegister.Application.Contracts.Identity;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Application.Models.Identity;
using DocumentRegister.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DocumentRegister.Infrastructure.Identity.Services
{
	public class AuthService : IAuthService
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly JwtSettings _jwtSettings;

		public AuthService(UserManager<ApplicationUser> userManager,
			IOptions<JwtSettings> jwtSettings,
			SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_jwtSettings = jwtSettings.Value;
			_signInManager = signInManager;
		}

		public async Task<AuthResponse> Login(AuthRequest request)
		{
			var user = await _userManager.FindByEmailAsync(request.Email);

			if (user == null)
			{
				throw new NotFoundException($"User with {request.Email} not found.", request.Email);
			}

			var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

			if (result.Succeeded == false)
			{
				throw new BadRequestException($"Credentials for '{request.Email} aren't valid'.");
			}

			JwtSecurityToken jwtSecurityToken = await GenerateToken(user);

			var response = new AuthResponse
			{
				Id = user.Id,
				Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
				Email = user.Email,
				UserName = user.UserName
			};

			return response;
		}


		public async Task<RegistrationResponse> Register(RegistrationRequest request)
		{
			var user = new ApplicationUser
			{
				Email = request.Email,
				FirstName = request.FirstName,
				LastName = request.LastName,
				UserName = request.UserName,
				EmailConfirmed = true
			};

			//create user
			var result = await _userManager.CreateAsync(user, request.Password);

			if (result.Succeeded)
			{
				//default: assign user to Employee role
				await _userManager.AddToRoleAsync(user, "Employee");
				return new RegistrationResponse() { UserId = user.Id };
			}
			else
			{
				StringBuilder str = new StringBuilder();
				foreach (var err in result.Errors)
				{
					str.AppendFormat("•{0}\n", err.Description);
				}

				throw new BadRequestException($"{str}");
			}
		}

		private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
		{
			//Retrieve user claims and roles from DB
			var userClaims = await _userManager.GetClaimsAsync(user);
			var roles = await _userManager.GetRolesAsync(user);

			var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();

			//consolidate all claims into array
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(JwtRegisteredClaimNames.Email, user.Email),
				new Claim("uid", user.Id)
			}
			.Union(userClaims)
			.Union(roleClaims);

			//generate key for token
			var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

			//generate hashed key
			var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

			//generate token
			var jwtSecurityToken = new JwtSecurityToken(
			   issuer: _jwtSettings.Issuer,
			   audience: _jwtSettings.Audience,
			   claims: claims,
			   expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
			   signingCredentials: signingCredentials);
			return jwtSecurityToken;
		}
	}
}
