using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages
{
    public partial class Register
    {
        public RegisterVM Model { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string Message { get; set; } 
        [Inject]
        private IAuthenticationService AuthenticationService { get; set; }

        protected override void OnInitialized()
        {
            Model = new RegisterVM();
        }

        protected async Task HandleRegister()
        {
            var result = await AuthenticationService.RegisterAsync(Model.FirstName, Model.LastName, Model.UserName, Model.Email, Model.Password);
            Message = result.ToString();
            if (result)
            {
                NavigationManager.NavigateTo("/login");
            }
            else
            {
                Message = "Registration failed";
            }
        }
    }
}
