using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.DeleteDocumentSegment
{
	public class DeleteDocumentSegmentCommandHandler : IRequestHandler<DeleteDocumentSegmentCommand, Unit>
	{
		private readonly IDocumentSegmentRepository _documentSegmentRepository;
        public DeleteDocumentSegmentCommandHandler(IDocumentSegmentRepository documentSegmentRepository)
        {
			_documentSegmentRepository = documentSegmentRepository;
		}
        public async Task<Unit> Handle(DeleteDocumentSegmentCommand request, CancellationToken cancellationToken)
		{
			var documentSegment = await _documentSegmentRepository.GetByIdAsync(request.DocumentSegmentId);

			if (documentSegment == null)
			{
				throw new NotFoundException(nameof(documentSegment), request.DocumentSegmentId);
			}

			await _documentSegmentRepository.DeleteAsync(documentSegment);

			return Unit.Value;
		}
	}
}
