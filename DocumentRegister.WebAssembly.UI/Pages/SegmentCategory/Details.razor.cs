using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.SegmentCategory
{
    public partial class Details
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
        DataTypeVM dataType = new DataTypeVM();

        [Parameter]
        public int id { get; set; }
        public string message { get; private set; } = string.Empty;
        bool isLoadingDataTypes = true;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                segmentCategory = await segmentCategoryService.GetSegmentCategory(id);
                dataType = await dataTypeService.GetDataTypeById(segmentCategory.DataTypeId);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}
