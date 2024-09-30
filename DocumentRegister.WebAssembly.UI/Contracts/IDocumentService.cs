using DocumentRegister.WebAssembly.UI.Models.Document;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IDocumentService
    {
        Task<List<DocumentVM>> GetDocuments();
        Task<DocumentVM> GetDocument(int id);
        //Task<Response<int>> CreateDocument(DocumentVM document);
        Task<int> CreateDocument(CreateDocumentVM document);
        Task<Response<int>> UpdateDocument(int id, DocumentVM document);
        Task<Response<int>> DeleteDocument(int id);
    }
}
