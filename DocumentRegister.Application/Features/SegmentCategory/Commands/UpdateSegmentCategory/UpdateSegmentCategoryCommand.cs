using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.UpdateSegmentCategory
{
	public class UpdateSegmentCategoryCommand : IRequest<Unit>
	{
        public int SegmentCategoryId { get; set; }
		public string Name { get; set; }
        public string Description { get; set; }
        public int DataTypeId { get; set; }
        public bool IsPredefined { get; set; }
    }
}
