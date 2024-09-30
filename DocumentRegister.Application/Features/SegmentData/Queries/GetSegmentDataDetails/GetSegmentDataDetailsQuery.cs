using DocumentRegister.Core.DTOs.SegmentData;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentDataDetails
{
	public class GetSegmentDataDetailsQuery : IRequest<SegmentDataDetailsDto>
	{
        public int SegmentDataId { get; set; }

        public GetSegmentDataDetailsQuery(int id)
        {
            this.SegmentDataId = id;
        }
    }
}
