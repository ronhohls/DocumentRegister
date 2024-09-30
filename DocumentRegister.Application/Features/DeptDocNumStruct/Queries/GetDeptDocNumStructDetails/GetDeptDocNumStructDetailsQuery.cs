using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructDetails
{
	public class GetDeptDocNumStructDetailsQuery : IRequest<DeptDocNumStructDetailsDto>
	{
        public int DeptDocNumStructId { get; set; }

        public GetDeptDocNumStructDetailsQuery(int id)
        {
            this.DeptDocNumStructId = id;
        }
    }
}
