using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    public class DeptDocNumStructRepository : GenericRepository<DeptDocNumStruct>, IDeptDocNumStructRepository
    {
        public DeptDocNumStructRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<DeptDocNumStruct>> GetAllDeptDocNumStructsWithDetails()
        {
            var deptDocNumStructs = await _dbContext.DeptDocNumStructs
                .Include(q => q.SegmentCategories).ThenInclude(q => q.DataType)
                .ToListAsync();

            return deptDocNumStructs;
        }

        public async Task<DeptDocNumStruct> GetDeptDocNumStructWithDetails(int id)
        {
            var deptDocNumStruct = await _dbContext.DeptDocNumStructs
                .Include(q => q.SegmentCategories).ThenInclude(q => q.DataType)
                .Include(q => q.SegmentCategories).ThenInclude(q => q.SegmentDatum)
                .FirstOrDefaultAsync(q => q.DeptDocNumStructId == id);

            return deptDocNumStruct;
        }
    }
}
