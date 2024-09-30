using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.Contracts.Persistence
{
    public interface ISegmentDataRepository : IGenericRepository<SegmentData>
    {
        Task<SegmentData> GetSegmentDataWithDetailsAsync(int id);
        Task<List<SegmentData>> GetAllSegmentDataWithDetailsAsync();
    }
}
