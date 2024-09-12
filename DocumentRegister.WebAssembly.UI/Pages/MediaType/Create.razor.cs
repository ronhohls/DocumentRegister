using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
	public partial class Create
	{
		[Inject]
		NavigationManager navigationManager { get; set; }
		[Inject]
		IMediaTypeService mediaTypeService { get; set; }
		[Inject]
		IToastService toastService { get; set; }
		public string Message { get; private set; }
		public MediaTypeVM mediaType { get; set; } = new MediaTypeVM();

		async Task CreateMediaType()
		{
			var response = await mediaTypeService.CreateMediaType(mediaType);
			if (response.Success)
			{
				toastService.ShowSuccess("Media Type created Successfully");
				toastService.ShowToast(ToastLevel.Info, "Test");
				navigationManager.NavigateTo("mediatypes");

			}
			else
			{
				Message = response.Message;
			}
		}
	}
}
