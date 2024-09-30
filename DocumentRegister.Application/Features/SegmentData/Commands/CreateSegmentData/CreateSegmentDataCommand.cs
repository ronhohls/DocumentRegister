using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.CreateSegmentData
{
	public class CreateSegmentDataCommand : IRequest<int>
	{
        public string Value { get; set; }
        public string Description { get; set; }
        public int SegmentCategoryId { get; set; }
    }
}
