using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Commands.DeleteMediaType
{
	public class DeleteMediaTypeCommand : IRequest<Unit>
	{
		public int MediaTypeId { get; set; }
    }
}
