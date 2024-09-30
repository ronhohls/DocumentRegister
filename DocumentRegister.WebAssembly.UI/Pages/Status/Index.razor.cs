using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IStatusService statusService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
		public List<StatusVM> statuses { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void CreateStatus()
        {
            navigationManager.NavigateTo("/statuses/create/");
        }

        protected void EditStatus(int id)
        {
            navigationManager.NavigateTo($"/statuses/edit/{id}");
        }

        protected void DetailsStatus(int id)
        {
			navigationManager.NavigateTo($"/statuses/details/{id}");
        }

        protected async Task DeleteStatus(int id)
        {
            var response = await statusService.DeleteStatus(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Status deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                message = response.Message;
                toastService.ShowError(message);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                statuses = await statusService.GetStatuses();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}