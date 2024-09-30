using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentRegister.Core.Entities
{
    public partial class DocumentSegment : BaseEntity
    {
        [Key]
        public int DocumentSegmentId { get; set; }

        [StringLength(100), Display(Name = "Category Name")]
        public string CategoryName { get; set; } = null!;

        [StringLength(250), Display(Name = "Category Description")]
        public string CategoryDescription { get; set; } = null!;

        [StringLength(100)]
        public string Value { get; set; } = null!;

        [StringLength(250), Display(Name = "Value Description")]
        public string ValueDescription { get; set; } = null!;

        public int DocumentId { get; set; }

        [ForeignKey("DocumentId")]
        public virtual Document Document { get; set; } = null!;
    }
}
