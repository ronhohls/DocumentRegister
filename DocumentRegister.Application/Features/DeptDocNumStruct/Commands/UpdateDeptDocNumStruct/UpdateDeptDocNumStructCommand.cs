using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.UpdateDeptDocNumStruct
{
	public class UpdateDeptDocNumStructCommand : IRequest<Unit>
	{
        public int DeptDocNumStructId { get; set; }
		public string Seperator { get; set; }
        public string Description { get; set; }
        public List<int> SegmentCategoryIds { get; set; } = new List<int>();
    }
}
