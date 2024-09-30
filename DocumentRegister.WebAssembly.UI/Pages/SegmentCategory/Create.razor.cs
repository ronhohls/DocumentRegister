using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentCategory
{
    public partial class Create
    {
        [Inject]
        ISegmentCategoryService segmentCategoryService { get; set; }
        [Inject]
        IDataTypeService dataTypeService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        SegmentCategoryVM segmentCategory { get; set; } = new SegmentCategoryVM();
        List<DataTypeVM> dataTypes { get; set; } = new List<DataTypeVM>();
        public string message { get; private set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                dataTypes = await dataTypeService.GetDataTypes();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }

        private async Task CreateSegmentCategory()
        {
            var response = await segmentCategoryService.CreateSegmentCategory(segmentCategory);

            if (response.Success)
            {
                toastService.ShowSuccess("Segment category created Successfully");
                navigationManager.NavigateTo("segmentCategories");
            }
            else
            {
                message = response.Message;
                toastService.ShowError(message);
            }
        }
    }
}
