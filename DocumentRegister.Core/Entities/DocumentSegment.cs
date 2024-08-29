using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class DocumentSegment
    {
        [Key]
        public int DocumentSegmentId { get; set; }

        [MaxLength(50), Display(Name = "Category Name")]
        public required string CategoryName { get; set; }

        [MaxLength(100), Display(Name = "Category Description")]
        public required string CategoryDescription { get; set; }

        [MaxLength(50)]
        public required string Value { get; set; }

        [MaxLength(100), Display(Name = "Value Description")]
        public required string ValueDescription { get; set; }
    }
}
