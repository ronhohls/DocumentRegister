using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;


namespace DocumentRegister.Application.Features.Status.Commands.UpdateStatus
{ 
    public class UpdateStatusCommandHandler : IRequestHandler<UpdateStatusCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IStatusRepository _statusRepository;

        public UpdateStatusCommandHandler(IMapper mapper, IStatusRepository statusRepository)
        {
            _mapper	= mapper;
			_statusRepository = statusRepository;
        }
        public async Task<Unit> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateStatusCommandValidator(_statusRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Status", validationResult);
			}

			var status = await _statusRepository.GetByIdAsync(request.StatusId);

			if (status == null)
			{
				throw new NotFoundException(nameof(status), request.StatusId);
			}

			_mapper.Map(request, status);
			await _statusRepository.UpdateAsync(status);

			return Unit.Value;
		}
	}
}
