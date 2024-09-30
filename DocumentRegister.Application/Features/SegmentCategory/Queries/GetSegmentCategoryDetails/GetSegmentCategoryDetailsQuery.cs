using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategoryDetails
{
	public class GetSegmentCategoryDetailsQuery : IRequest<SegmentCategoryDetailsDto>
	{
        public int SegmentCategoryId { get; set; }

        public GetSegmentCategoryDetailsQuery(int id)
        {
            this.SegmentCategoryId = id;
        }
    }
}
