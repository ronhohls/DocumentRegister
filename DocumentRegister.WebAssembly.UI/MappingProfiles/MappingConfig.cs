using AutoMapper;
using DocumentRegister.WebAssembly.UI.Models.DataType;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using DocumentRegister.WebAssembly.UI.Models.Document;
using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
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

			CreateMap<SegmentCategoriesDto, SegmentCategoryVM>().ReverseMap();
			CreateMap<SegmentCategoryDetailsDto, SegmentCategoryVM>().ReverseMap();
			CreateMap<CreateSegmentCategoryCommand, SegmentCategoryVM>().ReverseMap();
			CreateMap<UpdateSegmentCategoryCommand, SegmentCategoryVM>().ReverseMap();

            CreateMap<SegmentDataDto, SegmentDataVM>().ReverseMap();
            CreateMap<SegmentDataDetailsDto, SegmentDataVM>().ReverseMap();
            CreateMap<CreateSegmentDataCommand, SegmentDataVM>().ReverseMap();
            CreateMap<UpdateSegmentDataCommand, SegmentDataVM>().ReverseMap();

            CreateMap<DeptDocNumStructsDto, DeptDocNumStructVM>().ReverseMap();
            CreateMap<DeptDocNumStructDetailsDto, DeptDocNumStructVM>().ReverseMap();
            CreateMap<CreateDeptDocNumStructCommand, DeptDocNumStructVM>().ReverseMap();
            CreateMap<UpdateDeptDocNumStructCommand, DeptDocNumStructVM>().ReverseMap();

            CreateMap<DocumentSegmentDetailsDto, DocumentSegmentVM>().ReverseMap();
            CreateMap<DocumentSegmentsDto, DocumentSegmentVM>().ReverseMap();
            CreateMap<CreateDocumentSegmentCommand, DocumentSegmentVM>().ReverseMap();
            CreateMap<UpdateDocumentSegmentCommand, DocumentSegmentVM>().ReverseMap();

            CreateMap<DocumentsDto, DocumentVM>().ReverseMap();
            CreateMap<DocumentDetailsDto, DocumentVM>().ReverseMap();
            //CreateMap<CreateDocumentCommand, DocumentVM>().ReverseMap();
            CreateMap<UpdateDocumentCommand, DocumentVM>().ReverseMap();

            CreateMap<CreateDocumentDto, CreateDocumentVM>().ReverseMap();
            CreateMap<CreateDocumentSegmentDto, CreateDocumentSegmentVM>().ReverseMap();

            //CreateMap<List<DocumentSegmentVM>, List<Services.Base.CreateDocumentSegmentDto>>();

            //CreateMap<EmployeeVM, Employee>().ReverseMap();
        }
	}
}
