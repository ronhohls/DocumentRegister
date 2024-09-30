using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Models.MediaType;

namespace DocumentRegister.WebAssembly.UI.Models.Document
{
    public class DocumentVM
    {
        public int DocumentId { get; set; }
        public string Description { get; set; }
        public string DdnsDescription { get; set; }
        public string Seperator { get; set; }
        public string DocumentNumber { get; set; }
        public ICollection<DocumentSegmentVM> DocumentSegments { get; set; } = new List<DocumentSegmentVM>();
        public List<int> DocumentSegmentIds { get; set; } = new List<int>();

        public int StatusId { get; set; }
        public StatusVM? Status { get; set; }

        public int MediaTypeId { get; set; }
        public MediaTypeVM? MediaType { get; set; }

        public string Revision { get; set; }
        public string RequestedBy { get; set; }
        public string Location { get; set; }
    }
}
