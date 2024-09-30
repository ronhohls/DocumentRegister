using AutoMapper;
using DocumentRegister.Application.Features.SegmentData.Commands.CreateSegmentData;
using DocumentRegister.Application.Features.SegmentData.Commands.UpdateSegmentData;
using DocumentRegister.Core.DTOs.SegmentData;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class SegmentDataProfile : Profile
    {
        public SegmentDataProfile()
        {
            CreateMap<SegmentDataDto, SegmentData>().ReverseMap();
            CreateMap<SegmentDataDetailsDto, SegmentData>().ReverseMap();
            CreateMap<CreateSegmentDataCommand, SegmentData>();
            CreateMap<UpdateSegmentDataCommand, SegmentData>();
        }
    }
}
