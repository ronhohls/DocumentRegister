using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.DTOs.Document
{
    public class CreateDocumentDto
    {
        public string DocumentNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Seperator { get; set; } = string.Empty;
        public string DdnsDescription { get; set; } = string.Empty;
        public int StatusId { get; set; }
        public int MediaTypeId { get; set; }
        public string Revision { get; set; } = string.Empty;
        public string RequestedBy { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<CreateDocumentSegmentDto> DocumentSegments { get; set; } = new();
    }
}
