using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Features.Document.Commands.CreateBulkDocumentSegments;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.CreateBulkDocumentSegments
{
	public class CreateBulkDocumentSegmentsCommandHandler : IRequestHandler<CreateBulkDocumentSegmentsCommand, List<int>>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public CreateBulkDocumentSegmentsCommandHandler(IMapper mapper, IDocumentSegmentRepository documentSegmentRepository)
        {
			_mapper = mapper;
			_documentSegmentRepository = documentSegmentRepository;
		}

        public async Task<List<int>> Handle(CreateBulkDocumentSegmentsCommand request, CancellationToken cancellationToken)
		{
			var documentSegmentIds = new List<int>();

			foreach (var segmentCommand in request.DocumentSegments)
			{
                var documentSegment = _mapper.Map<DocumentRegister.Core.Entities.DocumentSegment>(request);
                await _documentSegmentRepository.CreateAsync(documentSegment);
                documentSegmentIds.Add(documentSegment.DocumentSegmentId);
            }

			return documentSegmentIds;

        }
	}
}
