using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentData
{
    public partial class Create
    {
        [Inject]
        ISegmentDataService segmentDataService { get; set; }
        [Inject]
        ISegmentCategoryService segmentCategoryService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        SegmentDataVM segmentData { get; set; } = new SegmentDataVM();
        List<SegmentCategoryVM> segmentCategories { get; set; } = new List<SegmentCategoryVM>();
        public string message { get; private set; } = string.Empty;

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

        private async Task CreateSegmentData()
        {
            var response = await segmentDataService.CreateSegmentData(segmentData);

            if (response.Success)
            {
                toastService.ShowSuccess("Segment Data created Successfully");
                navigationManager.NavigateTo("segmentData");
            }
            else
            {
                message = response.Message;
                toastService.ShowError(message);
            }
        }
    }
}
