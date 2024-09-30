using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using Microsoft.AspNetCore.Components;
using DocumentRegister.WebAssembly.UI.Services;

namespace DocumentRegister.WebAssembly.UI.Pages.DeptDocNumStruct
{
    public partial class Edit
    {
        [Inject]
        IDeptDocNumStructService deptDocNumStructService { get; set; }
        [Inject]
        ISegmentCategoryService segmentCategoryService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        DeptDocNumStructVM deptDocNumStruct { get; set; } = new DeptDocNumStructVM();
        
        //list of all segment categories retieved from the database
        List<SegmentCategoryVM> segmentCategories = new List<SegmentCategoryVM>();

        //the list related to the department document number structure
        List<SegmentCategoryVM> ddnsSegmentCategories = new List<SegmentCategoryVM>();

        [Parameter]
        public int id { get; set; }
        public string message { get; private set; } = string.Empty;
        public int index { get; set; } = 0;
        private int minSegmentCategories = 3;
        private int maxSegmentCategories = 6;
        

        protected override async Task OnInitializedAsync()
        {
            try
            {
                segmentCategories = await segmentCategoryService.GetSegmentCategories();
                deptDocNumStruct = await deptDocNumStructService.GetDeptDocNumStruct(id);
                ddnsSegmentCategories = deptDocNumStruct.SegmentCategories.ToList();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }

        private void AddSegmentCategory()
        {
            //add a new segment category to the list of segment categories to be added
            if (ddnsSegmentCategories.Count < maxSegmentCategories)
            {
                ddnsSegmentCategories.Add(new SegmentCategoryVM());
            }
            else
            {
                toastService.ShowWarning("You can only add a maximum of 6 segment categories");
            }
        }

        private void RemoveSegmentCategory(SegmentCategoryVM segmentCategory)
        {
            //remove a segment category from the list of segment categories to be added
            if (ddnsSegmentCategories.Count > minSegmentCategories)
            {
                ddnsSegmentCategories.Remove(segmentCategory);
            }
            else
            {
                toastService.ShowWarning("You must have at least 3 segment categories");
            }
        }

        private async Task EditDeptDocNumStruct()
        {
            deptDocNumStruct.SegmentCategoryIds = ddnsSegmentCategories
                .Select(c => c.SegmentCategoryId)
                .ToList();

            var response = await deptDocNumStructService.UpdateDeptDocNumStruct(id, deptDocNumStruct);

            if (response.Success)
            {
                toastService.ShowSuccess("Department Document Number Structure updated Successfully");
                navigationManager.NavigateTo("deptDocNumStructs");
            }
            else
            {
                message = response.Message;
                toastService.ShowError(message);
            }
        }
    }
}
