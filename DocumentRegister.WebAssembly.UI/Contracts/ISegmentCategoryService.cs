using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface ISegmentCategoryService
    {
		Task<List<SegmentCategoryVM>> GetSegmentCategories();
		Task<SegmentCategoryVM> GetSegmentCategory(int id);
		Task<Response<int>> CreateSegmentCategory(SegmentCategoryVM segmentCategory);
		Task<Response<int>> UpdateSegmentCategory(int id, SegmentCategoryVM segmentCategory);
		Task<Response<int>> DeleteSegmentCategory(int id);
	}
}
