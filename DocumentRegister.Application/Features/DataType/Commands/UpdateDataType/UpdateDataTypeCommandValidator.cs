using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.DataType.Commands.UpdateDataType
{
    public class UpdateDataTypeCommandValidator : AbstractValidator<UpdateDataTypeCommand>
	{
		private readonly IDataTypeRepository _dataTypeRepository;
        public UpdateDataTypeCommandValidator(IDataTypeRepository dataTypeRepository)
        {
			_dataTypeRepository = dataTypeRepository;

			RuleFor(p => p.Name)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(50).WithMessage("{propertyName} must be fewer than 50 characters");

		}
    }
}