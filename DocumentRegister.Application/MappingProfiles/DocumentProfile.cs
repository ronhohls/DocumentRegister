using AutoMapper;
using DocumentRegister.Application.Features.Document.Commands.CreateDocument;
using DocumentRegister.Application.Features.Document.Commands.UpdateDocument;
using DocumentRegister.Core.DTOs.Document;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<DocumentsDto, Document>().ReverseMap();
            CreateMap<DocumentDetailsDto, Document>().ReverseMap();
            CreateMap<CreateDocumentCommand, Document>();
            CreateMap<UpdateDocumentCommand, Document>();

            //only difference, is Document has DocumentId, Status and MediaType objects
            CreateMap<CreateDocumentDto, Document>()
                .ForMember(dest => dest.DocumentSegments, opt => opt.MapFrom(src => src.DocumentSegments));


            //difference, DocumentSegment has DocumentSegmentId and DocumentId and Document object
            CreateMap<CreateDocumentSegmentDto, DocumentSegment>();
        }
    }
}
