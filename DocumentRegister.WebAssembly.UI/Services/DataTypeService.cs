using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
	public class DataTypeService : BaseHttpService, IDataTypeService
	{
		private readonly IMapper _mapper;
		public DataTypeService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
		{
			_mapper = mapper;
		}

		public async Task<Response<int>> CreateDataType(DataTypeVM dataType)
		{
			try
			{
				await AddBearerToken();
				var createDataTypeCommand = _mapper.Map<CreateDataTypeCommand>(dataType);
				await _client.DataTypesPOSTAsync(createDataTypeCommand);
				return new Response<int>()
				{
					Success = true,
				};
			}
			catch (ApiException ex)
			{
				return ConvertApiExceptions<int>(ex);
			}
		}

		public async Task<Response<int>> DeleteDataType(int id)
		{
            try
            {
                await AddBearerToken();
                await _client.DataTypesDELETEAsync(id);
                return new Response<int>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

		public async Task<DataTypeVM> GetDataTypeById(int id)
		{
            await AddBearerToken();
            var dataType = await _client.DataTypesGETAsync(id);
            return _mapper.Map<DataTypeVM>(dataType);
        }

		public async Task<List<DataTypeVM>> GetDataTypes()
		{
            await AddBearerToken();
            var dataTypes = await _client.DataTypesAllAsync();
            return _mapper.Map<List<DataTypeVM>>(dataTypes);
        }

		public async Task<Response<int>> UpdateDataType(int id, DataTypeVM dataType)
		{
            try
            {
                await AddBearerToken();
                var updateDataTypeCommand = _mapper.Map<UpdateDataTypeCommand>(dataType);
                updateDataTypeCommand.DataTypeId = id;
                await _client.DataTypesPUTAsync(id.ToString(), updateDataTypeCommand);
                return new Response<int>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
	}
}