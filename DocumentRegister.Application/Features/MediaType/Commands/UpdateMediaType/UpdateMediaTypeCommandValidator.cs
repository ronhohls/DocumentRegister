using DocumentRegister.Application.Contracts.Persistence;
using FluentValidation;

namespace DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType
{
    public class UpdateMediaTypeCommandValidator : AbstractValidator<UpdateMediaTypeCommand>
	{
		private readonly IMediaTypeRepository _mediaTypeRepository;
        public UpdateMediaTypeCommandValidator(IMediaTypeRepository mediaTypeRepository)
        {
			_mediaTypeRepository = mediaTypeRepository;

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("{propertyName} is required")
				.MaximumLength(100).WithMessage("{propertyName} must be fewer than 100 characters");

		}
    }
}