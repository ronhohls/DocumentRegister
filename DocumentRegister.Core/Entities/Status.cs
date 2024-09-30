using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.Core.Entities
{
    public partial class Status : BaseEntity
    {
        [Key]
        public int StatusId { get; set; }

        [StringLength(100)]
        public string Description { get; set; } = null!;
    }
}
