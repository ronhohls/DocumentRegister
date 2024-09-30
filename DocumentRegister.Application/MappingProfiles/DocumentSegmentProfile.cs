using AutoMapper;
using DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment;
using DocumentRegister.Application.Features.DocumentSegment.Commands.UpdateDocumentSegment;
using DocumentRegister.Core.DTOs.DocumentSegment;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
    public class DocumentSegmentProfile : Profile
    {
        public DocumentSegmentProfile()
        {
            CreateMap<DocumentSegmentsDto, DocumentSegment>().ReverseMap();
            CreateMap<DocumentSegmentDetailsDto, DocumentSegment>().ReverseMap();
            CreateMap<CreateDocumentSegmentCommand, DocumentSegment>()
                .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId));
            CreateMap<UpdateDocumentSegmentCommand, DocumentSegment>();
        }
    }
}
