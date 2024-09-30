using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.UpdateDocumentSegment
{
	public class UpdateDocumentSegmentCommandHandler : IRequestHandler<UpdateDocumentSegmentCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public UpdateDocumentSegmentCommandHandler(IMapper mapper, IDocumentSegmentRepository documentSegmentRepository)
        {
			_mapper = mapper;
			_documentSegmentRepository = documentSegmentRepository;
		}

		public async Task<Unit> Handle(UpdateDocumentSegmentCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateDocumentSegmentCommandValidator(_documentSegmentRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			
			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Document Segment", validationResult);
			}

			var documentSegment = await _documentSegmentRepository.GetByIdAsync(request.DocumentSegmentId);

			if (documentSegment == null)
			{
				throw new NotFoundException(nameof(documentSegment), request.DocumentSegmentId);
			}

			_mapper.Map(request, documentSegment);
			await _documentSegmentRepository.UpdateAsync(documentSegment);

            return Unit.Value;
		}
	}
}
