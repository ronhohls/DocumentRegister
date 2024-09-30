using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.Contracts.Persistence
{
    public interface IDocumentSegmentRepository : IGenericRepository<DocumentSegment>
    {
        public Task<List<DocumentSegment>> GetDocumentSegmentsByIdList(List<int> idList);
    }
    
}
