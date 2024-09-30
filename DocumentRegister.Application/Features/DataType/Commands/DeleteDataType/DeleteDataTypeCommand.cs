using MediatR;

namespace DocumentRegister.Application.Features.DataType.Commands.DeleteDataType
{
	public class DeleteDataTypeCommand : IRequest<Unit>
	{
		public int DataTypeId { get; set; }
    }
}
