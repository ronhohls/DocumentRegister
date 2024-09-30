using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategoryDetails
{
	public class GetSegmentCategoryDetailsQueryHandler : IRequestHandler<GetSegmentCategoryDetailsQuery, SegmentCategoryDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public GetSegmentCategoryDetailsQueryHandler(IMapper mapper, ISegmentCategoryRepository segmentCategoryRepository)
        {
			_mapper = mapper;
			_segmentCategoryRepository = segmentCategoryRepository;
		}

		public async Task<SegmentCategoryDetailsDto> Handle(GetSegmentCategoryDetailsQuery request, CancellationToken cancellationToken)
		{
			var segmentCategory = await _segmentCategoryRepository.GetSegmentCategoryWithDetails(request.SegmentCategoryId);
			if (segmentCategory == null)
			{
				throw new NotFoundException(nameof(segmentCategory), request.SegmentCategoryId);
			}
			var data = _mapper.Map<SegmentCategoryDetailsDto>(segmentCategory);

			return data;
		}
	}
}
