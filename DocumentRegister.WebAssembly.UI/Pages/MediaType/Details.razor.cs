using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
	public partial class Details
	{
		[Inject]
		IMediaTypeService mediaTypeService { get; set; }

		[Parameter]
		public int id { get; set; }

		MediaTypeVM mediaType = new MediaTypeVM();

		protected async override Task OnParametersSetAsync()
		{
			mediaType = await mediaTypeService.GetMediaTypeById(id);
		}
	}
}