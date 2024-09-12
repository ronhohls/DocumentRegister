using MediatR;

namespace DocumentRegister.Application.Features.Status.Commands.DeleteStatus
{
	public class DeleteStatusCommand : IRequest<Unit>
	{
		public int StatusId { get; set; }
    }
}
