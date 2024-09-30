using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;

namespace DocumentRegister.WebAssembly.UI.Models.SegmentCategory
{
	public class SegmentCategoryVM
	{
        public int SegmentCategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int DataTypeId { get; set; }
		public DataTypeVM? DataType { get; set; } = new DataTypeVM();
        public virtual ICollection<SegmentDataVM> SegmentDatum { get; set; } = new List<SegmentDataVM>();
        public bool IsPredefined { get; set; }
    }
}
