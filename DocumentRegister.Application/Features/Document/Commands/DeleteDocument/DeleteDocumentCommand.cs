using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.DeleteDocument
{
	public class DeleteDocumentCommand : IRequest<Unit>
	{
        public int DocumentId { get; set; }

    }
}
