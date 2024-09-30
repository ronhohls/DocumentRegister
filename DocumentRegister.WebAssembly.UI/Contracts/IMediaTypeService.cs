using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IMediaTypeService
    {
		Task<List<MediaTypeVM>> GetMediaTypes();
		Task<MediaTypeVM> GetMediaTypeById(int id);
		Task<Response<int>> CreateMediaType(MediaTypeVM mediaType);
		Task<Response<int>> UpdateMediaType(int id, MediaTypeVM mediaType);
		Task<Response<int>> DeleteMediaType(int id);
	}
}
