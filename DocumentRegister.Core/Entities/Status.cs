using DocumentRegister.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class Status : BaseEntity
    {
        [Key]
        public int StatusId { get; set; }

        [MaxLength(100)]
        public required string Description { get; set; }
    }
}
