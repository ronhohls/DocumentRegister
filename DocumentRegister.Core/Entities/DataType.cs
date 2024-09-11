using DocumentRegister.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class DataType : BaseEntity
    {
        [Key]
        public int DataTypeId { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }
    }
}
