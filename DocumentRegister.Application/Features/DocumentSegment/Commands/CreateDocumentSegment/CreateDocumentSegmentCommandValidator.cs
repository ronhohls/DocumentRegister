using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment;
using FluentValidation;

namespace DocumentRegister.Application.Features.DocumentSegment.Commands.CreateDocumentSegment
{
	public class CreateDocumentSegmentCommandValidator : AbstractValidator<CreateDocumentSegmentCommand>
	{
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public CreateDocumentSegmentCommandValidator(IDocumentSegmentRepository documentSegmentRepository)
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

			RuleFor(p => p.DocumentId)
				.MustAsync(DocumentExists).WithMessage("DocumentId does not exist");
        }

		private async Task<bool> DocumentExists(int documentId, CancellationToken cancellationToken)
		{
			var document = await _documentSegmentRepository.GetByIdAsync(documentId);
			return document != null;
		}
    }
}
