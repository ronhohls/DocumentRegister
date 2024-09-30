using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
	public partial class Create
	{
		[Inject]
		NavigationManager navigationManager { get; set; }
		[Inject]
		IStatusService statusService { get; set; }
		[Inject]
		IToastService toastService { get; set; }
		public string message { get; private set; }
		public StatusVM status { get; set; } = new StatusVM();

		async Task CreateStatus()
		{
			var response = await statusService.CreateStatus(status);
			if (response.Success)
			{
				toastService.ShowSuccess("Status created Successfully");
				navigationManager.NavigateTo("statuses");
			}
			else
			{
				message = response.Message;
				toastService.ShowError(message);
			}
		}
	}
}
