using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Application.Features.DataType.Commands.DeleteDataType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.DataType.Commands.CreateDataType
{
    public class CreateDataTypeCommandHandler : IRequestHandler<CreateDataTypeCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IDataTypeRepository _dataTypeRepository;

        public CreateDataTypeCommandHandler(IMapper mapper, IDataTypeRepository dataTypeRepository)
        {
            _mapper	= mapper;
			_dataTypeRepository = dataTypeRepository;
        }
        public async Task<int> Handle(CreateDataTypeCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateDataTypeCommandValidator(_dataTypeRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Data Type", validationResult);
			}

			var dataType = _mapper.Map<DocumentRegister.Core.Entities.DataType>(request);
			await _dataTypeRepository.CreateAsync(dataType);

			return dataType.DataTypeId;
		}
	}
}
