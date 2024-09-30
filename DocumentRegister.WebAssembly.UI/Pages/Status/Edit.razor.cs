using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
	public partial class Edit
	{
		[Inject]
		IStatusService statusService { get; set; }
		[Inject]
		NavigationManager navigationManager { get; set; }
        [Inject]
        IToastService toastService { get; set; }

        [Parameter]
		public int id { get; set; }
		public string message { get; set; }

		StatusVM status = new StatusVM();

		protected override async Task OnParametersSetAsync()
		{
            try
            {
                status = await statusService.GetStatusById(id);

            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }

		async Task EditStatus()
		{
			var response = await statusService.UpdateStatus(id, status);
            if (response.Success)
			{
                toastService.ShowSuccess("Status Successfully Updated");
                navigationManager.NavigateTo("/statuses/");
			}
			else
			{
				message = response.Message;
				toastService.ShowError(message);
			}
		}
	}
}