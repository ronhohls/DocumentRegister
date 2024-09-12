using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IDataTypeService DataTypeService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> Logger { get; set; }
		public List<DataTypeVM> DataTypes { get; private set; }
        public string Message { get; set; } = string.Empty;

        protected void CreateDataType()
        {
            NavigationManager.NavigateTo("/datatypes/create/");
        }

        protected void EditDataType(int id)
        {
            NavigationManager.NavigateTo($"/datatypes/edit/{id}");
        }

        protected void DetailsDataType(int id)
        {
			NavigationManager.NavigateTo($"/datatypes/details/{id}");
        }

        protected async Task DeleteDataType(int id)
        {
            var response = await DataTypeService.DeleteDataType(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Data Type deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                Message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            DataTypes = await DataTypeService.GetDataTypes();
		}
    }
}