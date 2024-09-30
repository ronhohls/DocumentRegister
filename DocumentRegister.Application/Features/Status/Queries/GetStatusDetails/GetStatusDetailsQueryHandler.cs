using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.Status;
using MediatR;

namespace DocumentRegister.Application.Features.Status.Queries.GetStatusDetails
{
    public class GetStatusDetailsQueryHandler : IRequestHandler<GetStatusDetailsQuery, StatusDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IStatusRepository _statusRepository;

        public GetStatusDetailsQueryHandler(IMapper mapper, IStatusRepository statusRepository)
        {
			_mapper = mapper;
			_statusRepository = statusRepository;
		}
        public async Task<StatusDetailsDto> Handle(GetStatusDetailsQuery request, CancellationToken cancellationToken)
		{
			var status = await _statusRepository.GetByIdAsync(request.StatusId);
			if (status == null)
			{
				throw new NotFoundException(nameof(status), request.StatusId);
			}
			var data = _mapper.Map<StatusDetailsDto>(status);

			return data;
		}
	}
}
