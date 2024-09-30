using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
	public class MediaTypeService : BaseHttpService, IMediaTypeService
	{
		private readonly IMapper _mapper;
		public MediaTypeService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
		{
			_mapper = mapper;
		}

		public async Task<Response<int>> CreateMediaType(MediaTypeVM mediaType)
		{
			try
			{
				await AddBearerToken();
				var createMediaTypeCommand = _mapper.Map<CreateMediaTypeCommand>(mediaType);
				await _client.MediaTypesPOSTAsync(createMediaTypeCommand);
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

		public async Task<Response<int>> DeleteMediaType(int id)
		{
            try
            {
                await AddBearerToken();
                await _client.MediaTypesDELETEAsync(id);
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

		public async Task<MediaTypeVM> GetMediaTypeById(int id)
		{
            await AddBearerToken();
            var mediaType = await _client.MediaTypesGETAsync(id);
            return _mapper.Map<MediaTypeVM>(mediaType);
        }

		public async Task<List<MediaTypeVM>> GetMediaTypes()
		{
            await AddBearerToken();
            var mediaTypes = await _client.MediaTypesAllAsync();
            return _mapper.Map<List<MediaTypeVM>>(mediaTypes);
        }

		public async Task<Response<int>> UpdateMediaType(int id, MediaTypeVM mediaType)
		{
            try
            {
                await AddBearerToken();
                var updateMediaTypeCommand = _mapper.Map<UpdateMediaTypeCommand>(mediaType);
                updateMediaTypeCommand.MediaTypeId = id;
                await _client.MediaTypesPUTAsync(id.ToString(), updateMediaTypeCommand);
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