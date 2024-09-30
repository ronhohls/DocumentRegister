using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentRegister.Core.Entities
{
    public partial class SegmentData : BaseEntity
    {
        [Key]
        public int SegmentDataId { get; set; }

        [StringLength(250)]
        public required string Value { get; set; } = null!;

        [StringLength(250)]
        public string Description { get; set; } = null!;

        //many-to-one relationship with Segment Category        
        public int SegmentCategoryId { get; set; }

        [ForeignKey("SegmentCategoryId")]
        public virtual SegmentCategory SegmentCategory { get; set; } = null!;

    }
}
