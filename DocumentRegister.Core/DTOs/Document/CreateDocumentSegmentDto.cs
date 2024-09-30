namespace DocumentRegister.Core.DTOs.Document
{
    public class CreateDocumentSegmentDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string ValueDescription { get; set; } = string.Empty;
    }
}
