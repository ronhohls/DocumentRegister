using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IMediaTypeService MediaTypeService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> Logger { get; set; }
		public List<MediaTypeVM> MediaTypes { get; private set; }
        public string Message { get; set; } = string.Empty;

        protected void CreateMediaType()
        {
            NavigationManager.NavigateTo("/mediatypes/create/");
        }

        protected void EditMediaType(int id)
        {
            NavigationManager.NavigateTo($"/mediatypes/edit/{id}");
        }

        protected void DetailsMediaType(int id)
        {
			NavigationManager.NavigateTo($"/mediatypes/details/{id}");
        }

        protected async Task DeleteMediaType(int id)
        {
            var response = await MediaTypeService.DeleteMediaType(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Media Type deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                Message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            MediaTypes = await MediaTypeService.GetMediaTypes();
		}
    }
}