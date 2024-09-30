using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.CreateSegmentCategory
{
	public class CreateSegmentCategoryCommand : IRequest<int>
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public int DataTypeId { get; set; }
        public bool IsPredefined { get; set; }
    }
}
