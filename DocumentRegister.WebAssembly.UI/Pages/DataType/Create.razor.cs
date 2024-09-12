﻿using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
	public partial class Create
	{
		[Inject]
		NavigationManager navigationManager { get; set; }
		[Inject]
		IDataTypeService dataTypeService { get; set; }
		[Inject]
		IToastService toastService { get; set; }
		public string Message { get; private set; }
		public DataTypeVM dataType { get; set; } = new DataTypeVM();

		async Task CreateDataType()
		{
			var response = await dataTypeService.CreateDataType(dataType);
			if (response.Success)
			{
				toastService.ShowSuccess("Data Type created Successfully");
				toastService.ShowToast(ToastLevel.Info, "Test");
				navigationManager.NavigateTo("datatypes");

			}
			else
			{
				Message = response.Message;
			}
		}
	}
}
