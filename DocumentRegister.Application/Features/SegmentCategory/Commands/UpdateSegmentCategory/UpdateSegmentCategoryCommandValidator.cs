using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.UpdateSegmentCategory
{
	public class UpdateSegmentCategoryCommandValidator : AbstractValidator<UpdateSegmentCategoryCommand>
	{
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public UpdateSegmentCategoryCommandValidator(ISegmentCategoryRepository segmentCategoryRepository)
        {
			_segmentCategoryRepository = segmentCategoryRepository;

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(250).WithMessage("{propertyName} must be fewer than 250 characters");

			RuleFor(p => p.Name)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

			RuleFor(p => p.DataTypeId)
				.NotEmpty().WithMessage("{propertyName} is required");
		}
    }
}
