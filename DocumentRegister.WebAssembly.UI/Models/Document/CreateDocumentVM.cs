using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;

namespace DocumentRegister.WebAssembly.UI.Models.Document
{
    public class CreateDocumentVM
    {
        public string DocumentNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Seperator { get; set; } = string.Empty;
        public string DdnsDescription { get; set; } = string.Empty;
        public int StatusId { get; set; }
        public int MediaTypeId { get; set; }
        public string Revision { get; set; } = string.Empty;
        public string RequestedBy { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<CreateDocumentSegmentVM> DocumentSegments { get; set; } = new();
    }
}
