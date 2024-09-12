using AutoMapper;
using DocumentRegister.Application.Features.MediaType.Commands.CreateMediaType;
using DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType;
using DocumentRegister.Core.DTOs.MediaType;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class MediaTypeProfile : Profile
    {
        public MediaTypeProfile()
        {
            CreateMap<MediaTypesDto, MediaType>().ReverseMap();
            CreateMap<MediaType, MediaTypeDetailsDto>();
            CreateMap<CreateMediaTypeCommand, MediaType>();
            CreateMap<UpdateMediaTypeCommand, MediaType>();
        }
    }
}
