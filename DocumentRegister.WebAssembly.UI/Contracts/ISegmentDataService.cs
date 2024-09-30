using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface ISegmentDataService
    {
        Task<List<SegmentDataVM>> GetSegmentData();
        Task<SegmentDataVM> GetSegmentData(int id);
        Task<Response<int>> CreateSegmentData(SegmentDataVM segmentData);
        Task<Response<int>> UpdateSegmentData(int id, SegmentDataVM segmentData);
        Task<Response<int>> DeleteSegmentData(int id);
    }
}
