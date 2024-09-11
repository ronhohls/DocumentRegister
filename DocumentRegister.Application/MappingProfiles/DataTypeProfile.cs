using AutoMapper;
using DocumentRegister.Application.Features.DataType.Queries.GetDataTypes;
using DocumentRegister.Application.Features.DataType.Queries.GetDataTypeDetails;
using DocumentRegister.Application.Features.DataType.Commands.CreateDataType;
using DocumentRegister.Application.Features.DataType.Commands.UpdateDataType;
using DocumentRegister.Core.Entities;
using DocumentRegister.Core.DTOs.DataType;

namespace DocumentRegister.Application.MappingProfiles
{
	public class DataTypeProfile : Profile
	{
        public DataTypeProfile()
        {
			CreateMap<DataTypesDto, DataType>().ReverseMap();
            CreateMap<DataType, DataTypeDetailsDto>();
            CreateMap<CreateDataTypeCommand, DataType>();
			CreateMap<UpdateDataTypeCommand, DataType>();
		}
    }
}
