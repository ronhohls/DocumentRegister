using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentRegister.Core.Entities
{
    public partial class SegmentCategory : BaseEntity
    {
        [Key]
        public int SegmentCategoryId { get; set; }

        [StringLength(250)]
        public string Description { get; set; } = null!;

        [StringLength(50)]
        public string Name { get; set; } = null!;

        //many-to-one relationship with DataType
        public int DataTypeId { get; set; }

        [ForeignKey("DataTypeId")]
        public virtual DataType DataType { get; set; } = null!;

        //one-to-many relationship with SegmentData
        public virtual ICollection<SegmentData> SegmentDatum { get; set; } = new List<SegmentData>();

        //many-to-many relationship with DeptDocNumStruct
        public virtual ICollection<DeptDocNumStruct> DeptDocNumStructs { get; set; } = new List<DeptDocNumStruct>();

        //indicates whether user is to provide value or if value is taken from SegmentData
        public bool IsPredefined { get; set; }

    }
}
