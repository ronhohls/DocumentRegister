using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.DeleteDocument
{
	public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand, Unit>
	{
		private readonly IDocumentRepository _documentRepository;
        public DeleteDocumentCommandHandler(IDocumentRepository documentRepository)
        {
			_documentRepository = documentRepository;
		}
        public async Task<Unit> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
		{
			var document = await _documentRepository.GetByIdAsync(request.DocumentId);

			if (document == null)
			{
				throw new NotFoundException(nameof(document), request.DocumentId);
			}

			await _documentRepository.DeleteAsync(document);

			return Unit.Value;
		}
	}
}
