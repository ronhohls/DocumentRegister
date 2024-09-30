using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.UpdateDocumentSegment
{
	public class UpdateDocumentSegmentCommandValidator : AbstractValidator<UpdateDocumentSegmentCommand>
	{
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public UpdateDocumentSegmentCommandValidator(IDocumentSegmentRepository documentSegmentRepository)
        {
			_documentSegmentRepository = documentSegmentRepository;

            RuleFor(p => p.CategoryName)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(50).WithMessage("{propertyName} must be fewer than 50 characters");

            RuleFor(p => p.CategoryDescription)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.Value)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(50).WithMessage("{propertyName} must be fewer than 50 characters");

            RuleFor(p => p.ValueDescription)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");
        }
    }
}
