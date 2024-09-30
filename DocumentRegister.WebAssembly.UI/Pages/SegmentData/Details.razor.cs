using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentData
{
    public partial class Details
    {
        [Inject]
        ISegmentDataService segmentDataService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        SegmentDataVM segmentData { get; set; } = new SegmentDataVM();

        [Parameter]
        public int id { get; set; }
        public string message { get; private set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                segmentData = await segmentDataService.GetSegmentData(id);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}
