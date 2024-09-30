using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    public class DocumentSegmentRepository : GenericRepository<DocumentSegment>, IDocumentSegmentRepository
    {
        public DocumentSegmentRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<DocumentSegment>> GetDocumentSegmentsByIdList(List<int> idList)
        {
            List<DocumentSegment> documentSegmentsList = new List<DocumentSegment>();
            foreach (int id in idList)
            {
                documentSegmentsList.Add(await this.GetByIdAsync(id));
            }

            return documentSegmentsList;
        }
    }
}
