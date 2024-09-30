using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType
{
	public class UpdateMediaTypeCommand : IRequest<Unit>
	{
		public int MediaTypeId { get; set; }
		public string Description { get; set; } = string.Empty;
    }
}
