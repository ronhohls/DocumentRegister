using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategories
{
	public class GetSegmentCategoriesQueryHandler : IRequestHandler<GetSegmentCategoriesQuery, List<SegmentCategoriesDto>>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public GetSegmentCategoriesQueryHandler(IMapper mapper, ISegmentCategoryRepository segmentCategoryRepository) 
        {
            _mapper = mapper;
            _segmentCategoryRepository = segmentCategoryRepository;
        }

		public async Task<List<SegmentCategoriesDto>> Handle(GetSegmentCategoriesQuery request, CancellationToken cancellationToken)
		{
			var segmentCategories = await _segmentCategoryRepository.GetAllSegmentCategoriesWithDetails();
			var data = _mapper.Map<List<SegmentCategoriesDto>>(segmentCategories);

			return data;
		}
	}
}
