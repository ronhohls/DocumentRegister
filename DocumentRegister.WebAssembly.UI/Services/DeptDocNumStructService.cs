using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
    public class DeptDocNumStructService : BaseHttpService, IDeptDocNumStructService
    {
        private readonly IMapper _mapper;

        public DeptDocNumStructService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<Response<int>> CreateDeptDocNumStruct(DeptDocNumStructVM deptDocNumStruct)
        {
            try
            {
                await AddBearerToken();
                var createDeptDocNumStructCommand = _mapper.Map<CreateDeptDocNumStructCommand>(deptDocNumStruct);
                await _client.DeptDocNumStructPOSTAsync(createDeptDocNumStructCommand);
                return new Response<int>()
                {
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteDeptDocNumStruct(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.DeptDocNumStructDELETEAsync(id);
                return new Response<int>()
                {
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<DeptDocNumStructVM> GetDeptDocNumStruct(int id)
        {
            await AddBearerToken();
            var deptDocNumStruct = await _client.DeptDocNumStructGETAsync(id);
            return _mapper.Map<DeptDocNumStructVM>(deptDocNumStruct);
        }

        public async Task<IEnumerable<DeptDocNumStructVM>> GetDeptDocNumStructs()
        {
            await AddBearerToken();
            var deptDocNumStructs = await _client.DeptDocNumStructAllAsync();
            return _mapper.Map<IEnumerable<DeptDocNumStructVM>>(deptDocNumStructs);
        }

        public async Task<Response<int>> UpdateDeptDocNumStruct(int id, DeptDocNumStructVM deptDocNumStruct)
        {
            try
            {
                await AddBearerToken();
                var updateDeptDocNumStructCommand = _mapper.Map<UpdateDeptDocNumStructCommand>(deptDocNumStruct);
                updateDeptDocNumStructCommand.DeptDocNumStructId = id;
                await _client.DeptDocNumStructPUTAsync(id.ToString(), updateDeptDocNumStructCommand);
                return new Response<int>()
                {
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}