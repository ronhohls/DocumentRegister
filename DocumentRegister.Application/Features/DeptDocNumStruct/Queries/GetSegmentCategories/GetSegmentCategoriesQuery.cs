using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetSegmentCategories
{
    public class GetSegmentCategoriesQuery : IRequest<List<SegmentCategoryDetailsDto>>
    {
        public int DeptDocNumStructId { get; set; }

        public GetSegmentCategoriesQuery(int id)
        {
            this.DeptDocNumStructId = id;
        }
    }
}
