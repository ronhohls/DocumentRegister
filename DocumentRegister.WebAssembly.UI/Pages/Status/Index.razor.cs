using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IStatusService StatusService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
		public List<StatusVM> statuses { get; private set; }
        public string Message { get; set; } = string.Empty;

        protected void CreateStatus()
        {
            Console.WriteLine("CreateStatus");
            NavigationManager.NavigateTo("/statuses/create/");
        }

        protected void EditStatus(int id)
        {
            NavigationManager.NavigateTo($"/statuses/edit/{id}");
        }

        protected void DetailsStatus(int id)
        {
            System.Console.WriteLine("details");
			NavigationManager.NavigateTo($"/statuses/details/{id}");
        }

        protected async Task DeleteStatus(int id)
        {
            var response = await StatusService.DeleteStatus(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Status deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                Message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            statuses = await StatusService.GetStatuses();
			System.Console.WriteLine("on initialized");
		}
    }
}