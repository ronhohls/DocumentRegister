using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
	public partial class Details
	{
		[Inject]
		IStatusService statusService { get; set; }
		[Inject]
		IToastService toastService { get; set; }
		[Parameter]
		public int id { get; set; }
		string message { get; set; } = string.Empty;
		StatusVM status = new StatusVM();

		protected async override Task OnParametersSetAsync()
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
	}
}