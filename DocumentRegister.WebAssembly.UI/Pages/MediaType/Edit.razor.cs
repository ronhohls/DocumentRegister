using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
	public partial class Edit
	{
		[Inject]
		IMediaTypeService mediaTypeService { get; set; }
		[Inject]
		NavigationManager navigationManager { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Parameter]
		public int id { get; set; }
		public string message { get; set; }
		MediaTypeVM mediaType = new MediaTypeVM();

		protected override async Task OnParametersSetAsync()
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

		async Task EditMediaType()
		{
			var response = await mediaTypeService.UpdateMediaType(id, mediaType);
            if (response.Success)
			{
                toastService.ShowSuccess("Media Type Successfully Updated");
                navigationManager.NavigateTo("/mediatypes/");
			}
			else
			{
				message = response.Message;
				toastService.ShowError(message);
			}
		}
	}
}
