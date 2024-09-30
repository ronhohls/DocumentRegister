using DocumentRegister.Core.DTOs.Document;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.CreateDocument
{
	public class CreateDocumentCommand : IRequest<int>
	{
        //public string DocumentNumber { get; set; }
        //public string Description { get; set; }
        //public string DdnsDescription { get; set; }
        //public string Seperator { get; set; }
        //public int StatusId { get; set; }
        //public int MediaTypeId { get; set; }
        //public string Revision { get; set; }
        //public string RequestedBy { get; set; }
        //public string Location { get; set; }
        //public List<int> DocumentSegmentIds { get; set; } = new List<int>();
        public CreateDocumentDto Document { get; set; } = new CreateDocumentDto();

    }
}
