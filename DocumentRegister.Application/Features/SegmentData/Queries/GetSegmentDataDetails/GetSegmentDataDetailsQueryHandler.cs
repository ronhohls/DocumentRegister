using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentDataDetails;
using DocumentRegister.Core.DTOs.SegmentData;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentCategoryData
{
	public class GetSegmentDataDetailsQueryHandler : IRequestHandler<GetSegmentDataDetailsQuery, SegmentDataDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentDataRepository _segmentDataRepository;

        public GetSegmentDataDetailsQueryHandler(IMapper mapper, ISegmentDataRepository segmentDataRepository)
        {
			_mapper = mapper;
            _segmentDataRepository = segmentDataRepository;
		}

		public async Task<SegmentDataDetailsDto> Handle(GetSegmentDataDetailsQuery request, CancellationToken cancellationToken)
		{
			var segmentData = await _segmentDataRepository.GetSegmentDataWithDetailsAsync(request.SegmentDataId);
			if (segmentData == null)
			{
				throw new NotFoundException(nameof(segmentData), request.SegmentDataId);
			}
			var data = _mapper.Map<SegmentDataDetailsDto>(segmentData);

			return data;
		}
	}
}
