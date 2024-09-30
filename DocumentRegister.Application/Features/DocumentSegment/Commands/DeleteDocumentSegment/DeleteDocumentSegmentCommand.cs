using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.DeleteDocumentSegment
{
	public class DeleteDocumentSegmentCommand : IRequest<Unit>
	{
        public int DocumentSegmentId { get; set; }
    }
}
