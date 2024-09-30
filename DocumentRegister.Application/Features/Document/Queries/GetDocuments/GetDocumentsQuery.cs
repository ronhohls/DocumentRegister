using DocumentRegister.Core.DTOs.Document;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Queries.GetDocuments
{
	public class GetDocumentsQuery : IRequest<List<DocumentsDto>>
	{
        
    }
}
