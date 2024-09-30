using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.MediaType.Commands.CreateMediaType
{
    public class CreateMediaTypeCommandValidator : AbstractValidator<CreateMediaTypeCommand>
	{
		private readonly IMediaTypeRepository _mediaTypeRepository;
        public CreateMediaTypeCommandValidator(IMediaTypeRepository mediaTypeRepository)
        {
			_mediaTypeRepository = mediaTypeRepository;

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");
		}
    }
}