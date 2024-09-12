using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.MediaType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypes
{
    public class GetMediaTypesQueryHandler : IRequestHandler<GetMediaTypesQuery, List<MediaTypesDto>>
	{
		private readonly IMapper _mapper;
		private readonly IMediaTypeRepository _mediaTypeRepository;

        public GetMediaTypesQueryHandler(IMapper mapper, IMediaTypeRepository mediaTypeRepository)
        {
			_mapper = mapper;
			_mediaTypeRepository = mediaTypeRepository;
		}
        public async Task<List<MediaTypesDto>> Handle(GetMediaTypesQuery request, CancellationToken cancellationToken)
		{
			var mediaTypes = await _mediaTypeRepository.GetAllAsync();
			var data = _mapper.Map<List<MediaTypesDto>>(mediaTypes);

			return data;
		}
	}
}
