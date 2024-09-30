using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IDeptDocNumStructService
    {
        Task<IEnumerable<DeptDocNumStructVM>> GetDeptDocNumStructs();
        Task<DeptDocNumStructVM> GetDeptDocNumStruct(int id);
        Task<Response<int>> CreateDeptDocNumStruct(DeptDocNumStructVM deptDocNumStruct);
        Task<Response<int>> UpdateDeptDocNumStruct(int id, DeptDocNumStructVM deptDocNumStruct);
        Task<Response<int>> DeleteDeptDocNumStruct(int id);
    }
}
