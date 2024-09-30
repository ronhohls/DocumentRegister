using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
	public partial class Details
	{
		[Inject]
		IDataTypeService dataTypeService { get; set; }
        [Inject]
        IToastService toastService { get; set; }

        [Parameter]
		public int id { get; set; }

		DataTypeVM dataType = new DataTypeVM();
        string message = string.Empty;

		protected async override Task OnParametersSetAsync()
		{
            try
            {
                dataType = await dataTypeService.GetDataTypeById(id);
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
	}
}