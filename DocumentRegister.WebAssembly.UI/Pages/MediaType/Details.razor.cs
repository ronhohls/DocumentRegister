using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
	public partial class Details
	{
		[Inject]
		IMediaTypeService mediaTypeService { get; set; }
		[Inject]
		IToastService toastService { get; set; }

		[Parameter]
		public int id { get; set; }
		string message = string.Empty;
		MediaTypeVM mediaType = new MediaTypeVM();

		protected async override Task OnParametersSetAsync()
		{
            try
            {
                mediaType = await mediaTypeService.GetMediaTypeById(id);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
	}
}