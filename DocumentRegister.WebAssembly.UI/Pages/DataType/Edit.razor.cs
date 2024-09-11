using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
	public partial class Edit
	{
		[Inject]
		IDataTypeService DataTypeService { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		[Parameter]
		public int id { get; set; }
		public string Message { get; set; }

		DataTypeVM dataType = new DataTypeVM();

		protected override async Task OnParametersSetAsync()
		{
			dataType = await DataTypeService.GetDataTypeById(id);
		}

		async Task EditDataType()
		{
			var response = await DataTypeService.UpdateDataType(id, dataType);
			if (response.Success)
			{
				NavigationManager.NavigateTo("/datatypes/");
			}
			else
			{
				Message = response.Message;
			}
		}
	}
}
