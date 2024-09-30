using DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.CreateBulkDocumentSegments
{
    public class CreateBulkDocumentSegmentsCommand : IRequest<List<int>>
    {
        public List<CreateDocumentSegmentCommand> DocumentSegments { get; set; }
    }
}
