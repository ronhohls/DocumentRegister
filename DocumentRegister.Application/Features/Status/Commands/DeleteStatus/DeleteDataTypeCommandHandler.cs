using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.Status.Commands.DeleteStatus
{
    public class DeleteStatusCommandHandler : IRequestHandler<DeleteStatusCommand, Unit>
	{
		private readonly IStatusRepository _statusRepository;

		public DeleteStatusCommandHandler(IStatusRepository statusRepository)
		{
            _statusRepository = statusRepository;
		}
		public async Task<Unit> Handle(DeleteStatusCommand request, CancellationToken cancellationToken)
		{

			var status = await _statusRepository.GetByIdAsync(request.StatusId);

			if (status == null)
			{
				throw new NotFoundException(nameof(Status), request.StatusId);
			}

			await _statusRepository.DeleteAsync(status);

			return Unit.Value;
		}
	}
}
