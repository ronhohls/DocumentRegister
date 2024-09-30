using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.DocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegmentDetails
{
	public class GetDocumentSegmentDetailsQueryHandler : IRequestHandler<GetDocumentSegmentDetailsQuery, DocumentSegmentDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public GetDocumentSegmentDetailsQueryHandler(IMapper mapper, IDocumentSegmentRepository documentSegmentRepository)
        {
			_mapper = mapper;
			_documentSegmentRepository = documentSegmentRepository;
		}

		public async Task<DocumentSegmentDetailsDto> Handle(GetDocumentSegmentDetailsQuery request, CancellationToken cancellationToken)
		{
			var documentSegment = await _documentSegmentRepository.GetByIdAsync(request.DocumentSegmentId);
			if (documentSegment == null)
			{
				throw new NotFoundException(nameof(documentSegment), request.DocumentSegmentId);
			}
			var data = _mapper.Map<DocumentSegmentDetailsDto>(documentSegment);

			return data;
		}
	}
}
