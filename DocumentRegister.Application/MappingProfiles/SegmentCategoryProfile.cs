using AutoMapper;
using DocumentRegister.Application.Features.SegmentCategory.Commands.CreateSegmentCategory;
using DocumentRegister.Application.Features.SegmentCategory.Commands.UpdateSegmentCategory;
using DocumentRegister.Core.DTOs.SegmentCategory;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Application.MappingProfiles
{
	public class SegmentCategoryProfile : Profile
	{
        public SegmentCategoryProfile()
        {
			CreateMap<SegmentCategoriesDto, SegmentCategory>().ReverseMap();
			CreateMap<SegmentCategoryDetailsDto, SegmentCategory>().ReverseMap();
			CreateMap<CreateSegmentCategoryCommand, SegmentCategory>();
			CreateMap<UpdateSegmentCategoryCommand, SegmentCategory>();
		}
        
	}
}
