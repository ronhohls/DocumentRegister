using DocumentRegister.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.Core.Entities
{
    public partial class DataType : BaseEntity
    {
        [Key]
        public int DataTypeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
