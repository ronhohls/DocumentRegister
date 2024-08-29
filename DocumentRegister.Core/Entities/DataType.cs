using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class DataType
    {
        [Key]
        public int DataTypeId { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }
    }
}
