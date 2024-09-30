using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DeptDocNumStruct
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IDeptDocNumStructService deptDocNumStructService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
        public IEnumerable<DeptDocNumStructVM> deptDocNumStructs { get; private set; }
        public string message { get; set; } = string.Empty;
        public int numberOfCategories { get; set; } = 0;

        protected void CreateDeptDocNumStruct()
        {
            navigationManager.NavigateTo("/deptdocnumstructs/create/");
        }

        protected void EditDeptDocNumStruct(int id)
        {
            navigationManager.NavigateTo($"/deptdocnumstructs/edit/{id}");
        }

        protected void DetailsDeptDocNumStruct(int id)
        {
            navigationManager.NavigateTo($"/deptdocnumstructs/details/{id}");
        }

        protected async Task DeleteDeptDocNumStruct(int id)
        {
            var response = await deptDocNumStructService.DeleteDeptDocNumStruct(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Department Document Number Structure deleted Successfully");
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
                deptDocNumStructs = await deptDocNumStructService.GetDeptDocNumStructs();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}
