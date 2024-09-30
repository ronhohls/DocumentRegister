using MediatR;

namespace DocumentRegister.Application.Features.Status.Commands.CreateStatus
{ 
    public class CreateStatusCommand : IRequest<int>
	{
		public string Description { get; set; } = string.Empty;
    }
}
