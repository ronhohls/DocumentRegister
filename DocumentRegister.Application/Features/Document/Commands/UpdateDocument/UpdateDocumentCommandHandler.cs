using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.UpdateDocument
{
	public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentRepository _documentRepository;

        public UpdateDocumentCommandHandler(IMapper mapper, IDocumentRepository documentRepository)
        {
			_mapper = mapper;
			_documentRepository = documentRepository;
		}

		public async Task<Unit> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateDocumentCommandValidator(_documentRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			
			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Document", validationResult);
			}

			var document = await _documentRepository.GetByIdAsync(request.DocumentId);

			if (document == null)
			{
				throw new NotFoundException(nameof(document), request.DocumentId);
			}

			_mapper.Map(request, document);
			await _documentRepository.UpdateAsync(document);

            return Unit.Value;
		}
	}
}
