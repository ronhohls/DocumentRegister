using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;

namespace DocumentRegister.WebAssembly.UI.Models.SegmentData
{
    public class SegmentDataVM
    {
        public int SegmentDataId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int SegmentCategoryId { get; set; }
        public SegmentCategoryVM? SegmentCategory { get; set; } = new SegmentCategoryVM();
    }
}
