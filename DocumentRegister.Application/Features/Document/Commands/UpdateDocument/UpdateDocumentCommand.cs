using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.UpdateDocument
{
	public class UpdateDocumentCommand : IRequest<Unit>
	{
        public int DocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public string DeptDocNumStructDescription { get; set; }
        public string Seperator { get; set; }
        public int StatusId { get; set; }
        public int MediaTypeId { get; set; }
        public string Revision { get; set; }
        public string RequestedBy { get; set; }
        public string Location { get; set; }
        public List<int> DocumentSegmentIds = new List<int>();
    }
}
