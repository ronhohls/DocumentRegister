using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.Contracts.Persistence
{
    public interface IDocumentRepository : IGenericRepository<Document>
    {
        Task<Document> GetDocumentWithDetails(int id);
        Task<List<Document>> GetAllDocumentsWithDetails();
    }
}
