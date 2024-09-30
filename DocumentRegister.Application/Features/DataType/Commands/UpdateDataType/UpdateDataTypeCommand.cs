using MediatR;

namespace DocumentRegister.Application.Features.DataType.Commands.UpdateDataType
{
	public class UpdateDataTypeCommand : IRequest<Unit>
	{
		public int DataTypeId { get; set; }
		public string Name { get; set; } = string.Empty;
    }
}
