using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.CreateDocumentSegment
{
	public class CreateDocumentSegmentCommandHandler : IRequestHandler<CreateDocumentSegmentCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;
		private readonly IDocumentRepository _documentRepository;

        public CreateDocumentSegmentCommandHandler(IMapper mapper, IDocumentSegmentRepository documentSegmentRepository, IDocumentRepository documentRepository)
        {
			_mapper = mapper;
			_documentSegmentRepository = documentSegmentRepository;
			_documentRepository = documentRepository;
		}

        public async Task<int> Handle(CreateDocumentSegmentCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateDocumentSegmentCommandValidator(_documentSegmentRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				foreach (var error in validationResult.Errors)
                {
					Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
                }
                throw new BadRequestException("Invalid Segment Category");
			}

			var document = await _documentRepository.GetByIdAsync(request.DocumentId);
			if (document == null)
			{
				throw new NotFoundException($"Document with ID {request.DocumentId} not found.");
			}

			var documentSegment = _mapper.Map<DocumentRegister.Core.Entities.DocumentSegment>(request);
			await _documentSegmentRepository.CreateAsync(documentSegment);

			return documentSegment.DocumentSegmentId;
		}
	}
}
