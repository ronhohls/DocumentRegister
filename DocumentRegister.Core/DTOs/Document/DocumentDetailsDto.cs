using DocumentRegister.Core.DTOs.DocumentSegment;
using DocumentRegister.Core.DTOs.Status;
using DocumentRegister.Core.DTOs.MediaType;

namespace DocumentRegister.Core.DTOs.Document
{
    public class DocumentDetailsDto
    {
        public int DocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public string DdnsDescription { get; set; }
        public string Seperator { get; set; }
        public IEnumerable<DocumentSegmentDetailsDto> DocumentSegments { get; set; }
            = new List<DocumentSegmentDetailsDto>();
        public int StatusId { get; set; }
        public StatusDetailsDto? Status { get; set; }
        public int MediaTypeId { get; set; }
        public MediaTypeDetailsDto? MediaType { get; set; }
        public string Revision { get; set; }
        public string RequestedBy { get; set; }
        public string Location { get; set; }
    }
}
