using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
	public partial class Details
	{
		[Inject]
		IDataTypeService dataTypeService { get; set; }

		[Parameter]
		public int id { get; set; }

		DataTypeVM dataType = new DataTypeVM();

		protected async override Task OnParametersSetAsync()
		{
			dataType = await dataTypeService.GetDataTypeById(id);
		}
	}
}