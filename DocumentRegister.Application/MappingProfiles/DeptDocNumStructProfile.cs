using AutoMapper;
using DocumentRegister.Application.Features.DeptDocNumStruct.Commands.CreateDeptDocNumStruct;
using DocumentRegister.Application.Features.DeptDocNumStruct.Commands.UpdateDeptDocNumStruct;
using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class DeptDocNumStructProfile : Profile
    {
        public DeptDocNumStructProfile()
        {
            CreateMap<DeptDocNumStructsDto, DeptDocNumStruct>().ReverseMap();
            CreateMap<DeptDocNumStructDetailsDto, DeptDocNumStruct>().ReverseMap();
            CreateMap<CreateDeptDocNumStructCommand, DeptDocNumStruct>();
            CreateMap<UpdateDeptDocNumStructCommand, DeptDocNumStruct>();
        }
    }
}
