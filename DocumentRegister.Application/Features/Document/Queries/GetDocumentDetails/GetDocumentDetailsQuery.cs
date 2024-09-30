using DocumentRegister.Core.DTOs.Document;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Queries.GetDocumentDetails
{
	public class GetDocumentDetailsQuery : IRequest<DocumentDetailsDto>
	{
        public int DocumentId { get; set; }

        public GetDocumentDetailsQuery(int id)
        {
            this.DocumentId = id;
        }
    }
}
