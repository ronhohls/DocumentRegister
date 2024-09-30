using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Commands.CreateMediaType
{
    public class CreateMediaTypeCommandHandler : IRequestHandler<CreateMediaTypeCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IMediaTypeRepository _mediaTypeRepository;

        public CreateMediaTypeCommandHandler(IMapper mapper, IMediaTypeRepository mediaTypeRepository)
        {
            _mapper	= mapper;
			_mediaTypeRepository = mediaTypeRepository;
        }
        public async Task<int> Handle(CreateMediaTypeCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateMediaTypeCommandValidator(_mediaTypeRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Media Type", validationResult);
			}

			var mediaType = _mapper.Map<DocumentRegister.Core.Entities.MediaType>(request);
			await _mediaTypeRepository.CreateAsync(mediaType);

			return mediaType.MediaTypeId;
		}
	}
}
