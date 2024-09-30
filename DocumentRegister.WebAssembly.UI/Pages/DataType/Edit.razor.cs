using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
	public partial class Edit
	{
		[Inject]
		IDataTypeService dataTypeService { get; set; }
		[Inject]
		NavigationManager navigationManager { get; set; }
        [Inject]
        IToastService toastService { get; set; }

        [Parameter]
		public int id { get; set; }
		public string message { get; set; }

		DataTypeVM dataType = new DataTypeVM();

		protected override async Task OnParametersSetAsync()
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

		async Task EditDataType()
		{
			var response = await dataTypeService.UpdateDataType(id, dataType);
            if (response.Success)
			{
                toastService.ShowSuccess("Data Type Successfully Updated");
                navigationManager.NavigateTo("/datatypes/");
			}
			else
			{
				message = response.Message;
				toastService.ShowError(message);
			}
		}
	}
}