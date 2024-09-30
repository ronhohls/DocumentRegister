using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    class DocumentRepository : GenericRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Document>> GetAllDocumentsWithDetails()
        {
            var documents = await _dbContext.Documents
                .Include(q => q.DocumentSegments)
                .Include(q => q.Status)
                .Include(q => q.MediaType)
                .ToListAsync();

            return documents;
        }

        public async Task<Document> GetDocumentWithDetails(int id)
        {
            var document = await _dbContext.Documents
                .Include(q => q.Status)
                .Include(q => q.MediaType)
                .FirstOrDefaultAsync(q => q.DocumentId == id);

            return document;
        }
    }
}
