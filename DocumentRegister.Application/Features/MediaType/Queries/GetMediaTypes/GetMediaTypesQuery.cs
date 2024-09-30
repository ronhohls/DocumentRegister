using DocumentRegister.Core.DTOs.MediaType;
using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypes
{
	public class GetMediaTypesQuery : IRequest<List<MediaTypesDto>>
	{
	}
}
