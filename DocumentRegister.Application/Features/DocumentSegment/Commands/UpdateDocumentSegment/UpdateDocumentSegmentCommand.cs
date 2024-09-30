using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.UpdateDocumentSegment
{
	public class UpdateDocumentSegmentCommand : IRequest<Unit>
	{
        public int DocumentSegmentId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Value { get; set; }
        public string ValueDescription { get; set; }
        public int DocumentId { get; set; }
    }
}
