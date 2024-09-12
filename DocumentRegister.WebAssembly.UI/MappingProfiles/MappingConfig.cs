using AutoMapper;
using DocumentRegister.WebAssembly.UI.Models;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Models.Status;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.MappingProfiles
{
	public class MappingConfig : Profile
	{
		public MappingConfig() 
		{
			CreateMap<DataTypesDto, DataTypeVM>().ReverseMap();
			CreateMap<DataTypeDetailsDto, DataTypeVM>().ReverseMap();
			CreateMap<CreateDataTypeCommand, DataTypeVM>().ReverseMap();
			CreateMap<UpdateDataTypeCommand, DataTypeVM>().ReverseMap();

			CreateMap<StatusesDto, StatusVM>().ReverseMap();
			CreateMap<StatusDetailsDto, StatusVM>().ReverseMap();
			CreateMap<CreateStatusCommand, StatusVM>().ReverseMap();
			CreateMap<UpdateStatusCommand, StatusVM>().ReverseMap();

            CreateMap<MediaTypesDto, MediaTypeVM>().ReverseMap();
            CreateMap<MediaTypeDetailsDto, MediaTypeVM>().ReverseMap();
            CreateMap<CreateMediaTypeCommand, MediaTypeVM>().ReverseMap();
            CreateMap<UpdateMediaTypeCommand, MediaTypeVM>().ReverseMap();

            //CreateMap<EmployeeVM, Employee>().ReverseMap();
        }
	}
}
