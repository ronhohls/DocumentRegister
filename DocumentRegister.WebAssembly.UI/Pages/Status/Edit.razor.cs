using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
	public partial class Edit
	{
		[Inject]
		IStatusService StatusService { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		[Parameter]
		public int id { get; set; }
		public string Message { get; set; }

		StatusVM status = new StatusVM();

		protected override async Task OnParametersSetAsync()
		{
			status = await StatusService.GetStatusById(id);
		}

		async Task EditStatus()
		{
			var response = await StatusService.UpdateStatus(id, status);
			if (response.Success)
			{
				NavigationManager.NavigateTo("/statuses/");
			}
			else
			{
				Message = response.Message;
			}
		}
	}
}
