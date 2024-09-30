using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructs
{
	public class GetDeptDocNumStructsQueryHandler : IRequestHandler<GetDeptDocNumStructsQuery, IEnumerable<DeptDocNumStructsDto>>
	{
		private readonly IMapper _mapper;
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;

        public GetDeptDocNumStructsQueryHandler(IMapper mapper, IDeptDocNumStructRepository deptDocNumStructRepository) 
        {
            _mapper = mapper;
            _deptDocNumStructRepository = deptDocNumStructRepository;
        }

		public async Task<IEnumerable<DeptDocNumStructsDto>> Handle(GetDeptDocNumStructsQuery request, CancellationToken cancellationToken)
		{
			var deptDocNumStructs = await _deptDocNumStructRepository.GetAllDeptDocNumStructsWithDetails();
			var data = _mapper.Map<List<DeptDocNumStructsDto>>(deptDocNumStructs);

			return data;
		}
	}
}
