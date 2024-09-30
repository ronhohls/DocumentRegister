using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;

namespace DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct
{
    public class DeptDocNumStructVM
    {
        public int DeptDocNumStructId { get; set; }
        public string Seperator { get; set; }
        public string Description { get; set; }
        public IEnumerable<SegmentCategoryVM> SegmentCategories { get; set; }
        public List<int> SegmentCategoryIds { get; set; } = new List<int>();
    }
}
