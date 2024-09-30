using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructs
{
	public class GetDeptDocNumStructsQuery : IRequest<IEnumerable<DeptDocNumStructsDto>>
	{
		
    }
}
