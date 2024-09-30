using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.CreateDeptDocNumStruct
{
	public class CreateDeptDocNumStructCommand : IRequest<int>
	{
        public string Seperator { get; set; }
        public string Description { get; set; }
        public List<int> SegmentCategoryIds { get; set; } = new List<int>();
    }
}
