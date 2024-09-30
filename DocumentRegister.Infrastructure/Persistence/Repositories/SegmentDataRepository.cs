using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;
using DocumentRegister.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    public class SegmentDataRepository : GenericRepository<SegmentData>, ISegmentDataRepository
    {
        public SegmentDataRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<SegmentData> GetSegmentDataWithDetailsAsync(int id)
        {
            var segmentData = await _dbContext.SegmentDatum
                .Include(q => q.SegmentCategory)
                .Include(q => q.SegmentCategory.DataType)
                .FirstOrDefaultAsync(q => q.SegmentDataId == id);

            return segmentData;
        }

        public async Task<List<SegmentData>> GetAllSegmentDataWithDetailsAsync()
        {
            var segmentDataList = await _dbContext.SegmentDatum
                .Include(q => q.SegmentCategory)
                .Include(q => q.SegmentCategory.DataType)
                .ToListAsync();

            return segmentDataList;
        }
    }
}
