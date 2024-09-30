using DocumentRegister.Core.DTOs.SegmentCategory;

namespace DocumentRegister.Core.DTOs.DeptDocNumStruct
{
    public class DeptDocNumStructsDto
    {
        public int DeptDocNumStructId { get; set; }
        public string Seperator { get; set; }
        public string Description { get; set; }
        public IEnumerable<SegmentCategoryDetailsDto> SegmentCategories { get; set; } = new List<SegmentCategoryDetailsDto>();
    }
}
