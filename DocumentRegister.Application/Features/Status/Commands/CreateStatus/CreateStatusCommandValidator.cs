using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Features.DataType.Commands.CreateDataType;
using DocumentRegister.Application.Features.DataType.Commands.DeleteDataType;
using FluentValidation;

namespace DocumentRegister.Application.Features.Status.Commands.CreateStatus
{
    public class CreateStatusCommandValidator : AbstractValidator<CreateStatusCommand>
	{
		private readonly IStatusRepository _statusRepository;
        public CreateStatusCommandValidator(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

		}
    }
}