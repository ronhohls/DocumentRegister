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
    public class SegmentData
    {
        [Key]
        public int SegmentDataId { get; set; }

        public required string SegmentValue { get; set; }

        public required string SegmentValueDescription { get; set; }

        [ForeignKey("SegmentCategory")]
        public int SegmentCategoryId { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory { get; set; }
    }
}
