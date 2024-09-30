using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.DocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegments
{
	public class GetDocumentSegmentsQueryHandler : IRequestHandler<GetDocumentSegmentsQuery, List<DocumentSegmentsDto>>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public GetDocumentSegmentsQueryHandler(IMapper mapper, IDocumentSegmentRepository documentSegmentRepository) 
        {
            _mapper = mapper;
            _documentSegmentRepository = documentSegmentRepository;
        }

		public async Task<List<DocumentSegmentsDto>> Handle(GetDocumentSegmentsQuery request, CancellationToken cancellationToken)
		{
			var documentSegments = await _documentSegmentRepository.GetAllAsync();
			var data = _mapper.Map<List<DocumentSegmentsDto>>(documentSegments);

			return data;
		}
	}
}
