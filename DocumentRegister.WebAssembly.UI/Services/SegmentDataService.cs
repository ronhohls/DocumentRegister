using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
    public class SegmentDataService : BaseHttpService, ISegmentDataService
    {
        private readonly IMapper _mapper;

        public SegmentDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<Response<int>> CreateSegmentData(SegmentDataVM segmentData)
        {
            try
            {
                await AddBearerToken();
                var createSegmentDataCommand = _mapper.Map<CreateSegmentDataCommand>(segmentData);
                await _client.SegmentDataPOSTAsync(createSegmentDataCommand);
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

        public async Task<Response<int>> DeleteSegmentData(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.SegmentDataDELETEAsync(id);
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

        public async Task<List<SegmentDataVM>> GetSegmentData()
        {
            await AddBearerToken();
            var segmentData = await _client.SegmentDataAllAsync();
            return _mapper.Map<List<SegmentDataVM>>(segmentData);
        }

        public async Task<SegmentDataVM> GetSegmentData(int id)
        {
            await AddBearerToken();
            var segmentData = await _client.SegmentDataGETAsync(id);
            return _mapper.Map<SegmentDataVM>(segmentData);
        }

        public async Task<Response<int>> UpdateSegmentData(int id, SegmentDataVM segmentData)
        {
            try
            {
                await AddBearerToken();
                var updateSegmentDataCommand = _mapper.Map<UpdateSegmentDataCommand>(segmentData);
                updateSegmentDataCommand.SegmentDataId = id;
                await _client.SegmentDataPUTAsync(id.ToString(), updateSegmentDataCommand);
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