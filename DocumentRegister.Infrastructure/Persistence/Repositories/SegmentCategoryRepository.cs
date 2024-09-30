using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
	public class SegmentCategoryRepository : GenericRepository<SegmentCategory>, ISegmentCategoryRepository
	{
		public SegmentCategoryRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
		{

		}

		public async Task<List<SegmentCategory>> GetAllSegmentCategoriesWithDetails()
		{
			var segmentCategories = await _dbContext.SegmentCategories
				.Include(q => q.DataType)
				.Include(q => q.SegmentDatum)
				.ToListAsync();

			return segmentCategories;
		}

		public async Task<SegmentCategory> GetSegmentCategoryWithDetails(int id)
		{
			var segmentCategory = await _dbContext.SegmentCategories
				.Include(q => q.DataType)
                .Include(q => q.SegmentDatum)
                .FirstOrDefaultAsync(q => q.SegmentCategoryId == id);

			return segmentCategory;
		}

        public async Task<List<SegmentCategory>> GetSegmentCategoriesByIdList(List<int> idList)
        {
            List<SegmentCategory> segmentCategoriesList = new List<SegmentCategory>();
            foreach (int id in idList)
            {
                segmentCategoriesList.Add(await this.GetByIdAsync(id));
            }

			return segmentCategoriesList;
        }
    }
}
