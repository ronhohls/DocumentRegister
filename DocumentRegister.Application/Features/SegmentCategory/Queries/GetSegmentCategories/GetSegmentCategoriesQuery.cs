using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategories
{
	public class GetSegmentCategoriesQuery : IRequest<List<SegmentCategoriesDto>>
	{
        
    }
}
