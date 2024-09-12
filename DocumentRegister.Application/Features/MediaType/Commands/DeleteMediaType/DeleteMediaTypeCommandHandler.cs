using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.MediaType.Commands.DeleteMediaType
{
    public class DeleteMediaTypeCommandHandler : IRequestHandler<DeleteMediaTypeCommand, Unit>
	{
		private readonly IMediaTypeRepository _mediaTypeRepository;

		public DeleteMediaTypeCommandHandler(IMediaTypeRepository mediaTypeRepository)
		{
			_mediaTypeRepository = mediaTypeRepository;
		}
		public async Task<Unit> Handle(DeleteMediaTypeCommand request, CancellationToken cancellationToken)
		{

			var mediaType = await _mediaTypeRepository.GetByIdAsync(request.MediaTypeId);

			if (mediaType == null)
			{
				throw new NotFoundException(nameof(MediaType), request.MediaTypeId);
			}

			await _mediaTypeRepository.DeleteAsync(mediaType);

			return Unit.Value;
		}
	}
}
