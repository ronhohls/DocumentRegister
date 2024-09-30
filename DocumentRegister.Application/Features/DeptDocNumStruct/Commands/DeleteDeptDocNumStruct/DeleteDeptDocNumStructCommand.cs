using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.DeleteDeptDocNumStruct
{
	public class DeleteDeptDocNumStructCommand : IRequest<Unit>
	{
        public int DeptDocNumStructId { get; set; }
    }
}
