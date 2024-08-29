using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class SegmentCategory
    {
        [Key]
        public int SegmentCategoryId { get; set; }

        public required string Description { get; set; }

        public required string Name { get; set; }

        [ForeignKey("DataType")]
        public int DataTypeId { get; set; }

        [ValidateNever]
        public DataType? DataType { get; set; }

    }
}
