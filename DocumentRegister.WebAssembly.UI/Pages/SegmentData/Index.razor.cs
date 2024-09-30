using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentData
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public ISegmentDataService segmentDataService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
        public List<SegmentDataVM> segmentData { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void CreateSegmentData()
        {
            navigationManager.NavigateTo("/segmentdata/create/");
        }

        protected void EditSegmentData(int id)
        {
            navigationManager.NavigateTo($"/segmentdata/edit/{id}");
        }

        protected void DetailsSegmentData(int id)
        {
            navigationManager.NavigateTo($"/segmentdata/details/{id}");
        }

        protected async Task DeleteSegmentData(int id)
        {
            var response = await segmentDataService.DeleteSegmentData(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Segment Data deleted Successfully");
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
                segmentData = await segmentDataService.GetSegmentData();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}
