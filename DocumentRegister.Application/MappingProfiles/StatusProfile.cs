using AutoMapper;
using DocumentRegister.Application.Features.Status.Commands.CreateStatus;
using DocumentRegister.Application.Features.Status.Commands.UpdateStatus;
using DocumentRegister.Core.DTOs.Status;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class StatusProfile : Profile
    {
        public StatusProfile()
        {
            CreateMap<StatusesDto, Status>().ReverseMap();
            CreateMap<Status, StatusDetailsDto>();
            CreateMap<CreateStatusCommand, Status>();
            CreateMap<UpdateStatusCommand, Status>();
        }
    }
}
