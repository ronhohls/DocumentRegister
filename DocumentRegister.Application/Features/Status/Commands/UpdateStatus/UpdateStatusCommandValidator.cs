using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.Status.Commands.UpdateStatus
{
    public class UpdateStatusCommandValidator : AbstractValidator<UpdateStatusCommand>
	{
		private readonly IStatusRepository _statusRepository;
        public UpdateStatusCommandValidator(IStatusRepository statusRepository)
        {
			_statusRepository = statusRepository;

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

		}
    }
}