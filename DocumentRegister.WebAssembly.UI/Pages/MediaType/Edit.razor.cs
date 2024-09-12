using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
	public partial class Edit
	{
		[Inject]
		IMediaTypeService MediaTypeService { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		[Parameter]
		public int id { get; set; }
		public string Message { get; set; }

		MediaTypeVM mediaType = new MediaTypeVM();

		protected override async Task OnParametersSetAsync()
		{
			mediaType = await MediaTypeService.GetMediaTypeById(id);
		}

		async Task EditMediaType()
		{
			var response = await MediaTypeService.UpdateMediaType(id, mediaType);
			if (response.Success)
			{
				NavigationManager.NavigateTo("/mediatypes/");
			}
			else
			{
				Message = response.Message;
			}
		}
	}
}
