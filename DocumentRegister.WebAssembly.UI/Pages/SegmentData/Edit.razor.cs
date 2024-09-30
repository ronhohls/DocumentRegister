using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentData
{
    public partial class Edit
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
        List<SegmentCategoryVM> segmentCategories = new List<SegmentCategoryVM>();

        [Parameter]
        public int id { get; set; }
        public string message { get; private set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                segmentCategories = await segmentCategoryService.GetSegmentCategories();
                segmentData = await segmentDataService.GetSegmentData(id);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }

        private async Task EditSegmentData()
        {
            var response = await segmentDataService.UpdateSegmentData(id, segmentData);

            if (response.Success)
            {
                toastService.ShowSuccess("Segment Data updated Successfully");
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
