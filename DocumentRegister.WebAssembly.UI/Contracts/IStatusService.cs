using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IStatusService
    {
        Task<List<StatusVM>> GetStatuses();
        Task<StatusVM> GetStatusById(int id);
        Task<Response<int>> CreateStatus(StatusVM status);
        Task<Response<int>> UpdateStatus(int id, StatusVM status);
        Task<Response<int>> DeleteStatus(int id);
    }
}
