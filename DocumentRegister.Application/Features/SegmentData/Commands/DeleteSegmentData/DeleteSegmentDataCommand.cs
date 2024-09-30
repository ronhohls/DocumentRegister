using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.DeleteSegmentData
{ 
	public class DeleteSegmentDataCommand : IRequest<Unit>
	{
        public int SegmentDataId { get; set; }
    }
}
