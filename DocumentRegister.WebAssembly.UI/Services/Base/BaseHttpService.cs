using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace DocumentRegister.WebAssembly.UI.Services.Base
{
    public class BaseHttpService
    {
        protected  IClient _client;
        protected readonly ILocalStorageService _localStorage;
        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        protected Response<T> ConvertApiExceptions<T>(ApiException apiException)
        {
            if(apiException.StatusCode == 400)
            {
                return new Response<T>() 
                { 
                    Message = "Validation errors have occurred.",
                    ValidationErrors = apiException.Response,
                    Success = false
                };
            }
            if (apiException.StatusCode == 404)
            {
                return new Response<T>()
                {
                    Message = "The requested item has not been found",
                    Success = false
                };
            }
            if (apiException.StatusCode >= 200 &&  apiException.StatusCode <= 299)
            {
				return new Response<T>()
				{
					Message = "The Operation reported success",
					Success = true
				};

			}
            return new Response<T>()
            {
                Message = "Something went wrong, please try again",
                Success = false
            };
        }

        protected async Task GetBearerToken()
        {
            var token = await _localStorage.GetItemAsync<string>("token");
            if(token != null)
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
        }

        protected async Task AddBearerToken()
        {
            if (await _localStorage.ContainKeyAsync("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsync<string>("token"));
        }
    }
}
