using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.Status;
using MediatR;


namespace DocumentRegister.Application.Features.Status.Queries.GetStatuses
{
    public class GetStatusesQueryHandler : IRequestHandler<GetStatusesQuery, List<StatusesDto>>
	{
		private readonly IMapper _mapper;
		private readonly IStatusRepository _statusRepository;

        public GetStatusesQueryHandler(IMapper mapper, IStatusRepository statusRepository)
        {
			_mapper = mapper;
			_statusRepository = statusRepository;
		}
        public async Task<List<StatusesDto>> Handle(GetStatusesQuery request, CancellationToken cancellationToken)
		{
			var statuses = await _statusRepository.GetAllAsync();
			var data = _mapper.Map<List<StatusesDto>>(statuses);

			return data;
		}
	}
}
