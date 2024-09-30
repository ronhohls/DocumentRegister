using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructDetails
{
	public class GetDeptDocNumStructDetailsQueryHandler : IRequestHandler<GetDeptDocNumStructDetailsQuery, DeptDocNumStructDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;

        public GetDeptDocNumStructDetailsQueryHandler(IMapper mapper, IDeptDocNumStructRepository deptDocNumStructRepository)
        {
			_mapper = mapper;
            _deptDocNumStructRepository = deptDocNumStructRepository;
		}

		public async Task<DeptDocNumStructDetailsDto> Handle(GetDeptDocNumStructDetailsQuery request, CancellationToken cancellationToken)
		{
			var deptDocNumStruct = await _deptDocNumStructRepository.GetDeptDocNumStructWithDetails(request.DeptDocNumStructId);
			if (deptDocNumStruct == null)
			{
				throw new NotFoundException(nameof(deptDocNumStruct), request.DeptDocNumStructId);
			}
			var data = _mapper.Map<DeptDocNumStructDetailsDto>(deptDocNumStruct);

			return data;
		}
	}
}
