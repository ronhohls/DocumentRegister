using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.SegmentData;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentData
{
	public class GetSegmentDataQueryHandler : IRequestHandler<GetSegmentDataQuery, List<SegmentDataDto>>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentDataRepository _segmentDataRepository;

        public GetSegmentDataQueryHandler(IMapper mapper, ISegmentDataRepository segmentDataRepository) 
        {
            _mapper = mapper;
            _segmentDataRepository = segmentDataRepository;
        }

		public async Task<List<SegmentDataDto>> Handle(GetSegmentDataQuery request, CancellationToken cancellationToken)
		{
			var segmentDataList = await _segmentDataRepository.GetAllSegmentDataWithDetailsAsync();
			var dataList = _mapper.Map<List<SegmentDataDto>>(segmentDataList);

			return dataList;
		}
	}
}
