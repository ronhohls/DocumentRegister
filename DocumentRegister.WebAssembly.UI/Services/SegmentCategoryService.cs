using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
	public class SegmentCategoryService : BaseHttpService, ISegmentCategoryService
	{
		private readonly IMapper _mapper;

        public SegmentCategoryService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
			_mapper = mapper;
		}

		public async Task<Response<int>> CreateSegmentCategory(SegmentCategoryVM segmentCategory)
		{
			try
			{
				await AddBearerToken();
				var createSegmentCategoryCommand = _mapper.Map<CreateSegmentCategoryCommand>(segmentCategory);
				await _client.SegmentCategoryPOSTAsync(createSegmentCategoryCommand);
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

		public async Task<Response<int>> DeleteSegmentCategory(int id)
		{
			try
			{
				await AddBearerToken();
				await _client.SegmentCategoryDELETEAsync(id);
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

		public async Task<List<SegmentCategoryVM>> GetSegmentCategories()
		{
			await AddBearerToken();
			var segmentCategories = await _client.SegmentCategoryAllAsync();
			return _mapper.Map<List<SegmentCategoryVM>>(segmentCategories);
		}

		public async Task<SegmentCategoryVM> GetSegmentCategory(int id)
		{
			await AddBearerToken();
			var segmentCategory = await _client.SegmentCategoryGETAsync(id);
			return _mapper.Map<SegmentCategoryVM>(segmentCategory);
		}

		public async Task<Response<int>> UpdateSegmentCategory(int id, SegmentCategoryVM segmentCategory)
		{
			try
			{
				await AddBearerToken();
				var updateSegmentCategoryCommand = _mapper.Map<UpdateSegmentCategoryCommand>(segmentCategory);
				updateSegmentCategoryCommand.SegmentCategoryId = id;
				await _client.SegmentCategoryPUTAsync(id.ToString(), updateSegmentCategoryCommand);
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