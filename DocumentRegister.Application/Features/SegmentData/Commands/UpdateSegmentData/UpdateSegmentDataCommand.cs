using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.UpdateSegmentData
{ 
	public class UpdateSegmentDataCommand : IRequest<Unit>
	{
        public int SegmentDataId { get; set; }
		public string Value { get; set; }
        public string Description { get; set; }
        public int SegmentCategoryId { get; set; }
    }
}
