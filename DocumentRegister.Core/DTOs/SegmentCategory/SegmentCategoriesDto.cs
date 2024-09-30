using DocumentRegister.Core.DTOs.DataType;
using DocumentRegister.Core.DTOs.SegmentData;

namespace DocumentRegister.Core.DTOs.SegmentCategory
{
	public class SegmentCategoriesDto
	{
        public int SegmentCategoryId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int DataTypeId { get; set; }
		public DataTypeDetailsDto? DataType { get; set; }
        public IEnumerable<SegmentDataDetailsDto> SegmentDatum { get; set; } = new List<SegmentDataDetailsDto>();
        public bool IsPredefined { get; set; }
    }
}
