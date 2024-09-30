using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
	public interface IDataTypeService
	{
		Task<List<DataTypeVM>> GetDataTypes();
		Task<DataTypeVM> GetDataTypeById(int id);
		Task<Response<int>> CreateDataType(DataTypeVM dataType);
		Task<Response<int>> UpdateDataType(int id, DataTypeVM dataType);
		Task<Response<int>> DeleteDataType(int id);
	}
}
