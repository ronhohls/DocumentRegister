using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.Core.Entities
{
    public partial class MediaType : BaseEntity
    {
        [Key]
        public int MediaTypeId { get; set; }

        [StringLength(250)]
        public string Description { get; set; } = null!; 
    }
}
