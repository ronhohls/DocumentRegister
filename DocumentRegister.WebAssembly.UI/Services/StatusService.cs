using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
    public class StatusService : BaseHttpService, IStatusService
    {
        private readonly IMapper _mapper;
        public StatusService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<Response<Guid>> CreateStatus(StatusVM status)
        {
            try
            {
                await AddBearerToken();
                var createStatusCommand = _mapper.Map<CreateStatusCommand>(status);
                await _client.StatusesPOSTAsync(createStatusCommand);
                return new Response<Guid>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteStatus(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.StatusesDELETEAsync(id);
                return new Response<Guid>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<StatusVM> GetStatusById(int id)
        {
            //TODO: handle exceptions
            //try
            //{
            //    await AddBearerToken();
            //    var Status = await _client.StatussGETAsync(id);
            //    return _mapper.Map<StatusVM>(Status);
            //}
            //catch (ApiException ex)
            //{
            //    return ConvertApiExceptions(ex);
            //}
            await AddBearerToken();
            var status = await _client.StatusesGETAsync(id);
            return _mapper.Map<StatusVM>(status);
        }

        public async Task<List<StatusVM>> GetStatuses()
        {
            //TODO: handle exceptions
            //try
            //{
            //             await AddBearerToken();
            //             var Statuss = await _client.StatussAllAsync();
            //             return _mapper.Map<List<StatusVM>>(Statuss);
            //         }
            //catch (ApiException ex)
            //{
            //             return ConvertApiExceptions<Guid>(ex);
            //         }
            await GetBearerToken();
            //await AddBearerToken();
            var statuses = await _client.StatusesAllAsync();
            return _mapper.Map<List<StatusVM>>(statuses);
        }

        public async Task<Response<Guid>> UpdateStatus(int id, StatusVM status)
        {
            try
            {
                await AddBearerToken();
                var updateStatusCommand = _mapper.Map<UpdateStatusCommand>(status);
                updateStatusCommand.StatusId = id;
                await _client.StatusesPUTAsync(id.ToString(), updateStatusCommand);
                return new Response<Guid>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
