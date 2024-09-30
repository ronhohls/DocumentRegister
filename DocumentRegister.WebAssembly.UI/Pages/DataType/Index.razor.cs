using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IDataTypeService dataTypeService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
		public List<DataTypeVM> dataTypes { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void CreateDataType()
        {
            navigationManager.NavigateTo("/datatypes/create/");
        }

        protected void EditDataType(int id)
        {
            navigationManager.NavigateTo($"/datatypes/edit/{id}");
        }

        protected void DetailsDataType(int id)
        {
			navigationManager.NavigateTo($"/datatypes/details/{id}");
        }

        protected async Task DeleteDataType(int id)
        {
            var response = await dataTypeService.DeleteDataType(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Data Type deleted Successfully");
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
                dataTypes = await dataTypeService.GetDataTypes();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}