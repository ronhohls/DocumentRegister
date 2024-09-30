using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.CreateDeptDocNumStruct
{
	public class CreateDeptDocNumStructCommandValidator : AbstractValidator<CreateDeptDocNumStructCommand>
	{
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;

        public CreateDeptDocNumStructCommandValidator(IDeptDocNumStructRepository deptDocNumStructRepository)
        {
            _deptDocNumStructRepository = deptDocNumStructRepository;

            RuleFor(p => p.Seperator)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(5).WithMessage("{propertyName} must be no more than 5 characters");

            RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");
		}
    }
}
