using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using Microsoft.AspNetCore.Components;
using DocumentRegister.WebAssembly.UI.Services;

namespace DocumentRegister.WebAssembly.UI.Pages.DeptDocNumStruct
{
    public partial class Create
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
        List<SegmentCategoryVM> segmentCategories { get; set; } = new List<SegmentCategoryVM>();

        //the list of segment categories to be added to the department document number structure

        List<SegmentCategoryVM> newSegmentCategories { get; set; } = new List<SegmentCategoryVM>();
        public string message { get; private set; } = string.Empty;
        private int minSegmentCategories = 3; 
        private int maxSegmentCategories = 6;
        public int index { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {
            //initialise list of all segment categories
            try
            {
                segmentCategories = await segmentCategoryService.GetSegmentCategories();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }

            //initialise the list of segment categories to be added
            for (int i = 0; i < minSegmentCategories; i++)
            {
                newSegmentCategories.Add(new SegmentCategoryVM { SegmentCategoryId = 0});
            }
        }

        private void AddSegmentCategory()
        {
            //add a new segment category to the list of segment categories to be added
            if (newSegmentCategories.Count < maxSegmentCategories)
            {
                newSegmentCategories.Add(new SegmentCategoryVM { SegmentCategoryId = 0 });
            }
            else
            {
                toastService.ShowWarning("You can only add a maximum of 6 segment categories");
            }
        }

        private void RemoveSegmentCategory(SegmentCategoryVM segmentCategory)
        {
            //remove a segment category from the list of segment categories to be added
            if (newSegmentCategories.Count > minSegmentCategories)
            {
                newSegmentCategories.Remove(segmentCategory);
            }
            else
            {
                toastService.ShowWarning("You must have at least 3 segment categories");
            }
        }

        private async Task CreateDeptDocNumStruct()
        {
            //add the selected segment categories to the department document number structure 
            deptDocNumStruct.SegmentCategoryIds = newSegmentCategories
                .Select(c => c.SegmentCategoryId)
                .ToList();
            
            var response = await deptDocNumStructService.CreateDeptDocNumStruct(deptDocNumStruct);

            if (response.Success)
            {
                toastService.ShowSuccess("Department Document Number Structure created Successfully");
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