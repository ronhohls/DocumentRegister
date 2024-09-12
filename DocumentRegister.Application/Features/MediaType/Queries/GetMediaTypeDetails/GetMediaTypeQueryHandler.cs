using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.MediaType;
using MediatR;


namespace DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypeDetails
{
    public class GetMediaTypeDetailsQueryHandler : IRequestHandler<GetMediaTypeDetailsQuery, MediaTypeDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IMediaTypeRepository _mediaTypeRepository;

        public GetMediaTypeDetailsQueryHandler(IMapper mapper, IMediaTypeRepository mediaTypeRepository)
        {
			_mapper = mapper;
			_mediaTypeRepository = mediaTypeRepository;
		}
        public async Task<MediaTypeDetailsDto> Handle(GetMediaTypeDetailsQuery request, CancellationToken cancellationToken)
		{
			var mediaType = await _mediaTypeRepository.GetByIdAsync(request.MediaTypeId);
			if (mediaType == null)
			{
				throw new NotFoundException(nameof(mediaType), request.MediaTypeId);
			}
			var data = _mapper.Map<MediaTypeDetailsDto>(mediaType);

			return data;
		}
	}
}
