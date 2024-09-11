using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
	public interface IDataTypeService
	{
		Task<List<DataTypeVM>> GetDataTypes();
		Task<DataTypeVM> GetDataTypeById(int id);
		Task<Response<Guid>> CreateDataType(DataTypeVM dataType);
		Task<Response<Guid>> UpdateDataType(int id, DataTypeVM dataType);
		Task<Response<Guid>> DeleteDataType(int id);
	}
}
