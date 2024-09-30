namespace DocumentRegister.WebAssembly.UI.Models.DocumentSegment
{
    public class CreateDocumentSegmentVM
    {
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string ValueDescription { get; set; } = string.Empty;
        public int? SegmentDataId { get; set; }
    }
}
