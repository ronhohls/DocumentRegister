using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentRegister.Core.Entities
{
    public partial class Document : BaseEntity
    {
        [Key]
        public int DocumentId { get; set; }

        [StringLength(250)]
        public string Description { get; set; } = null!;

        [Column("DDNSDescription")]
        [StringLength(100), Display(Name = "Department Document Number Structure Description")]
        public string DdnsDescription { get; set; } = null!;

        [StringLength(5)]
        public string Seperator { get; set; } = null!;

        public string DocumentNumber { get; set; } = null!;

        //one-to-many relationship with DocumentSegment
        public virtual ICollection<DocumentSegment> DocumentSegments { get; set; } = new List<DocumentSegment>();


        //many-to-one relationship with Status
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; } = null!;

        //many-to-one relationship with MediaType
        public int MediaTypeId { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual MediaType MediaType { get; set; } = null!;

        [StringLength(100)]
        public string Revision { get; set; }

        [StringLength(100)]
        public string RequestedBy { get; set; }

        public string Location { get; set; }


    }
}
