using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DocumentRegister.WebAssembly.UI.Providers
{
	public class ApiAuthenticationStateProvider : AuthenticationStateProvider
	{
        private readonly ILocalStorageService _localStorage;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;
		public ApiAuthenticationStateProvider(ILocalStorageService localStorage)
        {
			_localStorage = localStorage;
			_jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
		}

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            var savedToken = await _localStorage.GetItemAsync<string>("token");
            if (savedToken == null)
            {
                return new AuthenticationState(user);
            }
            var tokenContent = _jwtSecurityTokenHandler.ReadJwtToken(savedToken);

            if (tokenContent.ValidTo < DateTime.UtcNow)
            {
				return new AuthenticationState(user);
			}

            var claims = await GetClaims();

            user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));

            return new AuthenticationState(user);
        }

        public async Task LoggedIn()
        {
            var claims = await GetClaims();
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            //update auth state for user
            var authState = Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(authState);
        }

        public async Task LoggedOut()
        {
            await _localStorage.RemoveItemAsync("token");
            //update auth state for empty claims principal
            var nobody = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(nobody));
			NotifyAuthenticationStateChanged(authState);
		}

        private async Task<List<Claim>> GetClaims()
        {
            //retrieve token
			var savedToken = await _localStorage.GetItemAsync<string>("token");
            //parse token
			var tokenContent = _jwtSecurityTokenHandler.ReadJwtToken(savedToken);
            //retrieve claims from token
			var claims = tokenContent.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, tokenContent.Subject));
            return claims;
		}
    }
}
