using DocumentRegister.Core.DTOs.DocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegmentDetails
{
	public class GetDocumentSegmentDetailsQuery : IRequest<DocumentSegmentDetailsDto>
	{
        public int DocumentSegmentId { get; set; }

        public GetDocumentSegmentDetailsQuery(int id)
        {
            this.DocumentSegmentId = id;
        }
    }
}
