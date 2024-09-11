using MediatR;

namespace DocumentRegister.Application.Features.DataType.Commands.CreateDataType
{
	public class CreateDataTypeCommand : IRequest<int>
	{
		public string Name { get; set; } = string.Empty;
    }
}
