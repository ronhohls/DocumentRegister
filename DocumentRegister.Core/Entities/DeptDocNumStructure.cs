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
    public  class DeptDocNumStructure
    {
        [Key]
        public int DeptDocNumStructureId { get; set; }

        [MaxLength(5)]
        public required string Seperator { get; set; }

        [MaxLength(50)]
        public required string Description { get; set; }

        [ForeignKey("SegmentCategory")]
        public required int SegmentCategoryId1 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory1 { get; set; }

        [ForeignKey("SegmentCategory")]
        public required int SegmentCategoryId2 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory2 { get; set; }

        [ForeignKey("SegmentCategory")]
        public required int SegmentCategoryId3 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory3 { get; set; }

        [ForeignKey("SegmentCategory")]
        public int SegmentCategoryId4 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory4 { get; set; }

        [ForeignKey("SegmentCategory")]
        public int SegmentCategoryId5 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory5 { get; set; }

        [ForeignKey("SegmentCategory")]
        public int SegmentCategoryId6 { get; set; }

        [ValidateNever]
        public SegmentCategory? SegmentCategory6 { get; set; }
    }
}
