﻿using DocumentRegister.Application.Contracts.Identity;
using DocumentRegister.Application.Models.Identity;
using DocumentRegister.Infrastructure.Identity.DbContext;
using DocumentRegister.Infrastructure.Identity.Models;
using DocumentRegister.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DocumentRegister.Infrastructure.Identity
{
	public static class IdentityDependencyInjection
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

			services.AddDbContext<DocumentRegisterIdentityDbContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("DocumentRegisterAppConnection"));
			});

			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<DocumentRegisterIdentityDbContext>()
				.AddDefaultTokenProviders();

			services.AddTransient<IAuthService, AuthService>();
			services.AddTransient<IUserService, UserService>();

			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(o =>
			{
				o.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ClockSkew = TimeSpan.Zero,
					ValidIssuer = configuration["JwtSettings:Issuer"],
					ValidAudience = configuration["JwtSettings:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))

				};
			});

			return services;
		}
	}
}
