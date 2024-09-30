using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DeptDocNumStruct
{
    public partial class Details
    {
        [Inject]
        IDeptDocNumStructService deptDocNumStructService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        DeptDocNumStructVM deptDocNumStruct { get; set; } = new DeptDocNumStructVM();

        [Parameter]
        public int id { get; set; }
        public string message { get; private set; } = string.Empty;

        bool isLoadingSegmentCategories = true;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                deptDocNumStruct = await deptDocNumStructService.GetDeptDocNumStruct(id);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
            finally
            {
                isLoadingSegmentCategories = false;
            }

            if (deptDocNumStruct == null)
            {
                message = "No data found.";
                toastService.ShowError(message);
            }
        }
    }
}