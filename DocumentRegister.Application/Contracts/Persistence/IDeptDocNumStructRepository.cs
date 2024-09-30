using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.Contracts.Persistence
{
    public interface IDeptDocNumStructRepository : IGenericRepository<DeptDocNumStruct>
    {
        Task<IEnumerable<DeptDocNumStruct>> GetAllDeptDocNumStructsWithDetails();
        Task<DeptDocNumStruct> GetDeptDocNumStructWithDetails(int id);
    }
}
