using AutoMapper;
using DocumentRegister.WebAssembly.UI.Models;
using DocumentRegister.WebAssembly.UI.Models.DataType;
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

			//CreateMap<EmployeeVM, Employee>().ReverseMap();
		}
	}
}
