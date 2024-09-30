using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.DeleteDeptDocNumStruct
{
	public class DeleteDeptDocNumStructCommandHandler : IRequestHandler<DeleteDeptDocNumStructCommand, Unit>
	{
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;
        public DeleteDeptDocNumStructCommandHandler(IDeptDocNumStructRepository deptDocNumStructRepository)
        {
            _deptDocNumStructRepository = deptDocNumStructRepository;
		}
        public async Task<Unit> Handle(DeleteDeptDocNumStructCommand request, CancellationToken cancellationToken)
		{
			var deptDocNumStruct = await _deptDocNumStructRepository.GetByIdAsync(request.DeptDocNumStructId);

			if (deptDocNumStruct == null)
			{
				throw new NotFoundException(nameof(deptDocNumStruct), request.DeptDocNumStructId);
			}

			await _deptDocNumStructRepository.DeleteAsync(deptDocNumStruct);

			return Unit.Value;
		}
	}
}
