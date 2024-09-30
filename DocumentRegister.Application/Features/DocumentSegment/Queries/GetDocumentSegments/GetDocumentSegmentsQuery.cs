using DocumentRegister.Core.DTOs.DocumentSegment;
using MediatR;

namespace DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegments
{
	public class GetDocumentSegmentsQuery : IRequest<List<DocumentSegmentsDto>>
	{
        
    }
}
