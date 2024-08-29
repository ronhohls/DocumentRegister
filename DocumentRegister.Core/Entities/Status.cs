using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        public required string Description { get; set; }
    }
}
