using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.DeleteSegmentCategory
{
	public class DeleteSegmentCategoryCommand : IRequest<Unit>
	{
        public int SegmentCategoryId { get; set; }
    }
}
