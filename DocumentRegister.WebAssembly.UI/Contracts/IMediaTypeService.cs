using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IMediaTypeService
    {
		Task<List<MediaTypeVM>> GetMediaTypes();
		Task<MediaTypeVM> GetMediaTypeById(int id);
		Task<Response<Guid>> CreateMediaType(MediaTypeVM mediaType);
		Task<Response<Guid>> UpdateMediaType(int id, MediaTypeVM mediaType);
		Task<Response<Guid>> DeleteMediaType(int id);
	}
}
