using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }

        [MaxLength(100), Display(Name = "Document Number")]
        public required string DocumentNumber { get; set; }

        [MaxLength(100)]
        public required string Description { get; set; }

        [MaxLength(5)]
        public required string Seperator { get; set; }

        [ForeignKey("DocumentSegment")]
        public required int DocumentSegment1Id { get; set; }

        [ForeignKey("DocumentSegment")]
        public required int DocumentSegment2Id { get; set; }

        [ForeignKey("DocumentSegment")]
        public required int DocumentSegment3Id { get; set; }

        [ForeignKey("DocumentSegment")]
        public int DocumentSegment4Id { get; set; }

        [ForeignKey("DocumentSegment")]
        public int DocumentSegment5Id { get; set; }

        [ForeignKey("DocumentSegment")]
        public int DocumentSegment6Id { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }

        [ForeignKey("MediaType")]
        public int MediaTypeId { get; set; }


    }
}
