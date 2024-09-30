using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentCategory
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public ISegmentCategoryService segmentCategoryService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
        public List<SegmentCategoryVM> segmentCategories { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void CreateSegmentCategory()
        {
            navigationManager.NavigateTo("/segmentcategories/create/");
        }

        protected void EditSegmentCategory(int id)
        {
            navigationManager.NavigateTo($"/segmentcategories/edit/{id}");
        }

        protected void DetailsSegmentCategory(int id)
        {
            navigationManager.NavigateTo($"/segmentcategories/details/{id}");
        }

        protected async Task DeleteSegmentCategory(int id)
        {
            var response = await segmentCategoryService.DeleteSegmentCategory(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Segment Category deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                message = response.Message;
                toastService.ShowError(message);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                segmentCategories = await segmentCategoryService.GetSegmentCategories();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}
