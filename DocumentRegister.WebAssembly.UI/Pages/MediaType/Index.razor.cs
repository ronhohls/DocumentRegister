using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IMediaTypeService mediaTypeService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
		public List<MediaTypeVM> mediaTypes { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void CreateMediaType()
        {
            navigationManager.NavigateTo("/mediatypes/create/");
        }

        protected void EditMediaType(int id)
        {
            navigationManager.NavigateTo($"/mediatypes/edit/{id}");
        }

        protected void DetailsMediaType(int id)
        {
			navigationManager.NavigateTo($"/mediatypes/details/{id}");
        }

        protected async Task DeleteMediaType(int id)
        {
            var response = await mediaTypeService.DeleteMediaType(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Media Type deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                message = response.Message;
                toastService?.ShowError(message);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                mediaTypes = await mediaTypeService.GetMediaTypes();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}