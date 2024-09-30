using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment
{
	public class CreateDocumentSegmentCommand : IRequest<int>
	{
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Value { get; set; }
        public string ValueDescription { get; set; }
        public int DocumentId { get; set; }
    }
}
