using DocumentRegister.Core.DTOs.SegmentCategory;

namespace DocumentRegister.Core.DTOs.SegmentData
{
    public class SegmentDataDto
    {
        public int SegmentDataId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int SegmentCategoryId { get; set; }
        public SegmentCategoryDetailsDto? SegmentCategory { get; set; }
    }
}
