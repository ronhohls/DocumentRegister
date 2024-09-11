using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.DataType.Commands.DeleteDataType
{
    public class DeleteDataTypeCommandHandler : IRequestHandler<DeleteDataTypeCommand, Unit>
	{
		private readonly IDataTypeRepository _dataTypeRepository;

		public DeleteDataTypeCommandHandler(IDataTypeRepository dataTypeRepository)
		{
			_dataTypeRepository = dataTypeRepository;
		}
		public async Task<Unit> Handle(DeleteDataTypeCommand request, CancellationToken cancellationToken)
		{

			var dataType = await _dataTypeRepository.GetByIdAsync(request.DataTypeId);

			if (dataType == null)
			{
				throw new NotFoundException(nameof(DataType), request.DataTypeId);
			}

			await _dataTypeRepository.DeleteAsync(dataType);

			return Unit.Value;
		}
	}
}
