using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.Core.Entities
{
    public partial class DeptDocNumStruct : BaseEntity
    {
        [Key]
        public int DeptDocNumStructId { get; set; }

        [StringLength(5)]
        public string Seperator { get; set; } = null!;

        [StringLength(250)]
        public string Description { get; set; } = null!;

        //Many-to-many relationship with SegementCategory
        public virtual ICollection<SegmentCategory> SegmentCategories{ get; set; } = new List<SegmentCategory>();

    }
}
