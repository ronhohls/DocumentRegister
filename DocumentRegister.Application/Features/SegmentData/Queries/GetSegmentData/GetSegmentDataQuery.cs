using DocumentRegister.Core.DTOs.SegmentData;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentData
{
	public class GetSegmentDataQuery : IRequest<List<SegmentDataDto>>
	{
        
    }
}
