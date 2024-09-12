using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;


namespace DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType
{
    public class UpdateMediaTypeCommandHandler : IRequestHandler<UpdateMediaTypeCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IMediaTypeRepository _mediaTypeRepository;

        public UpdateMediaTypeCommandHandler(IMapper mapper, IMediaTypeRepository mediaTypeRepository)
        {
            _mapper	= mapper;
			_mediaTypeRepository = mediaTypeRepository;
        }
        public async Task<Unit> Handle(UpdateMediaTypeCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateMediaTypeCommandValidator(_mediaTypeRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Media Type", validationResult);
			}

			var mediaType = await _mediaTypeRepository.GetByIdAsync(request.MediaTypeId);

			if (mediaType == null)
			{
				throw new NotFoundException(nameof(mediaType), request.MediaTypeId);
			}

			_mapper.Map(request, mediaType);
			await _mediaTypeRepository.UpdateAsync(mediaType);

			return Unit.Value;
		}
	}
}
