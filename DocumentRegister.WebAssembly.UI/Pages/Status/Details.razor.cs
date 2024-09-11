using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
	public partial class Details
	{
		[Inject]
		IStatusService statusService { get; set; }

		[Parameter]
		public int id { get; set; }

		StatusVM status = new StatusVM();

		protected async override Task OnParametersSetAsync()
		{
			status = await statusService.GetStatusById(id);
		}
	}
}