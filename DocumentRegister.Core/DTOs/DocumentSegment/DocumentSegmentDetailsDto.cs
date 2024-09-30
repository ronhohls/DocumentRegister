namespace DocumentRegister.Core.DTOs.DocumentSegment
{
    public class DocumentSegmentDetailsDto
    {
        public int DocumentSegmentId { get; set; }

        public  string CategoryName { get; set; }

        public  string CategoryDescription { get; set; }

        public  string Value { get; set; }

        public  string ValueDescription { get; set; }
        public int DocumentId { get; set; }
    }
}
