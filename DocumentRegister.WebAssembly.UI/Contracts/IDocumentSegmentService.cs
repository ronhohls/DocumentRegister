using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Contracts
{
    public interface IDocumentSegmentService
    {
        Task<List<DocumentSegmentVM>> GetDocumentSegments();
        Task<DocumentSegmentVM> GetDocumentSegment(int id);
        Task<Response<int>> CreateDocumentSegment(DocumentSegmentVM documentSegment);
        Task<Response<List<int>>> CreateDocumentSegments(List<DocumentSegmentVM> documentSegments);
        Task<Response<int>> UpdateDocumentSegment(int id, DocumentSegmentVM documentSegment);
        Task<Response<int>> DeleteDocumentSegment(int id);
    }
}
