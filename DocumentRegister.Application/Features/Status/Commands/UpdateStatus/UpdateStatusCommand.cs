using MediatR;

namespace DocumentRegister.Application.Features.Status.Commands.UpdateStatus
{
	public class UpdateStatusCommand : IRequest<Unit>
	{
		public int StatusId { get; set; }
		public string Description { get; set; } = string.Empty;
    }
}
