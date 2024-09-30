using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.SegmentData.Commands.UpdateSegmentData
{
	public class UpdateSegmentDataCommandValidator : AbstractValidator<UpdateSegmentDataCommand>
	{
		private readonly ISegmentDataRepository _segmentDataRepository;

        public UpdateSegmentDataCommandValidator(ISegmentDataRepository segmentDataRepository)
        {
            _segmentDataRepository = segmentDataRepository;

            RuleFor(p => p.Value)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(250).WithMessage("{propertyName} must be fewer than 250 characters");

			RuleFor(p => p.SegmentCategoryId)
				.NotEmpty().WithMessage("{propertyName} is required");
		}
    }
}
