using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.DataType;
using MediatR;


namespace DocumentRegister.Application.Features.DataType.Queries.GetDataTypeDetails
{
    public class GetDataTypeDetailsQueryHandler : IRequestHandler<GetDataTypeDetailsQuery, DataTypeDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IDataTypeRepository _dataTypeRepository;

        public GetDataTypeDetailsQueryHandler(IMapper mapper, IDataTypeRepository dataTypeRepository)
        {
			_mapper = mapper;
			_dataTypeRepository = dataTypeRepository;
		}
        public async Task<DataTypeDetailsDto> Handle(GetDataTypeDetailsQuery request, CancellationToken cancellationToken)
		{
			var dataTypes = await _dataTypeRepository.GetByIdAsync(request.DataTypeId);
			if (dataTypes == null)
			{
				throw new NotFoundException(nameof(dataTypes), request.DataTypeId);
			}
			var data = _mapper.Map<DataTypeDetailsDto>(dataTypes);

			return data;
		}
	}
}
