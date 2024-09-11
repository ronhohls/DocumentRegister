using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Application.Features.DataType.Commands.CreateDataType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.DataType.Commands.UpdateDataType
{
    public class UpdateDataTypeCommandHandler : IRequestHandler<UpdateDataTypeCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IDataTypeRepository _dataTypeRepository;

        public UpdateDataTypeCommandHandler(IMapper mapper, IDataTypeRepository dataTypeRepository)
        {
            _mapper	= mapper;
			_dataTypeRepository = dataTypeRepository;
        }
        public async Task<Unit> Handle(UpdateDataTypeCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateDataTypeCommandValidator(_dataTypeRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Data Type", validationResult);
			}

			var dataType = await _dataTypeRepository.GetByIdAsync(request.DataTypeId);

			if (dataType == null)
			{
				throw new NotFoundException(nameof(dataType), request.DataTypeId);
			}

			_mapper.Map(request, dataType);
			await _dataTypeRepository.UpdateAsync(dataType);

			return Unit.Value;
		}
	}
}
