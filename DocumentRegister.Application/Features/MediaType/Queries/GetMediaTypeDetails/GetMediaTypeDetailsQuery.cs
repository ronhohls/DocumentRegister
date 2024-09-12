using DocumentRegister.Core.DTOs.MediaType;
using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypeDetails
{
	public class GetMediaTypeDetailsQuery : IRequest<MediaTypeDetailsDto>
	{
		public int MediaTypeId { get; set; }

		public GetMediaTypeDetailsQuery(int id)
		{
			this.MediaTypeId = id;
		}
	}
}
