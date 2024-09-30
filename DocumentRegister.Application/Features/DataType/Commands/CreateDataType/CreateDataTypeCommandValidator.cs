using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.DataType.Commands.CreateDataType
{
    public class CreateDataTypeCommandValidator : AbstractValidator<CreateDataTypeCommand>
	{
		private readonly IDataTypeRepository _dataTypeRepository;
        public CreateDataTypeCommandValidator(IDataTypeRepository dataTypeRepository)
        {
			_dataTypeRepository = dataTypeRepository;

			RuleFor(p => p.Name)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(50).WithMessage("{propertyName} must be fewer than 50 characters");

		}
    }
}