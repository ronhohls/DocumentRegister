using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.Document.Commands.UpdateDocument
{
	public class UpdateDocumentCommandValidator : AbstractValidator<UpdateDocumentCommand>
	{
		private readonly IDocumentRepository _documentRepository;

        public UpdateDocumentCommandValidator(IDocumentRepository documentRepository)
        {
			_documentRepository = documentRepository;
            RuleFor(p => p.DocumentNumber)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(250).WithMessage("{propertyName} must be fewer than 250 characters");

            RuleFor(p => p.DeptDocNumStructDescription)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.Seperator)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(5).WithMessage("{propertyName} must be fewer than 6 characters");

            RuleFor(p => p.StatusId)
                .NotEmpty().WithMessage("{propertyName} is required");

            RuleFor(p => p.MediaTypeId)
                .NotEmpty().WithMessage("{propertyName} is required");

            RuleFor(p => p.Revision)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.RequestedBy)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

            RuleFor(p => p.Location)
                .NotEmpty().WithMessage("{propertyName} is required")
                .MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");
        }
    }
}
