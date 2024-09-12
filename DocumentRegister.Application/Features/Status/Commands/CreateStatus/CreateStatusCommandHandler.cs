using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;


namespace DocumentRegister.Application.Features.Status.Commands.CreateStatus
{
    public class CreateStatusCommandHandler : IRequestHandler<CreateStatusCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IStatusRepository _statusRepository;

        public CreateStatusCommandHandler(IMapper mapper, IStatusRepository statusRepository)
        {
            _mapper	= mapper;
            _statusRepository = statusRepository;
        }
        public async Task<int> Handle(CreateStatusCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateStatusCommandValidator(_statusRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Status", validationResult);
			}

			var status = _mapper.Map<DocumentRegister.Core.Entities.Status>(request);
			await _statusRepository.CreateAsync(status);

			return status.StatusId;
		}
	}
}
