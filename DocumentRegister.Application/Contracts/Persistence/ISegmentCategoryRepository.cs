using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.Contracts.Persistence
{
	public interface ISegmentCategoryRepository : IGenericRepository<SegmentCategory>
	{
		Task<SegmentCategory> GetSegmentCategoryWithDetails(int id);
		Task<List<SegmentCategory>> GetAllSegmentCategoriesWithDetails();
		Task<List<SegmentCategory>> GetSegmentCategoriesByIdList(List<int> idList);
	}
}
