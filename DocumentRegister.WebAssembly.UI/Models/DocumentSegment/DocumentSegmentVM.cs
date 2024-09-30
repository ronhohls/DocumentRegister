namespace DocumentRegister.WebAssembly.UI.Models.DocumentSegment
{
    public class DocumentSegmentVM
    {
        public int DocumentSegmentId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Value { get; set; }
        public string ValueDescription { get; set; }
        public int DocumentId { get; set; }
        public int? SegmentDataId { get; set; }
    }
}
