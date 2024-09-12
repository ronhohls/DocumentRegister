using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Commands.CreateMediaType
{
	public class CreateMediaTypeCommand : IRequest<int>
	{
		public string Description { get; set; } = string.Empty;
    }
}
