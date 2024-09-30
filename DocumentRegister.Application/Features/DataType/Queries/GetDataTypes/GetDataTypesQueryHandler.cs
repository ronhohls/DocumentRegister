using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.DataType;
using MediatR;

namespace DocumentRegister.Application.Features.DataType.Queries.GetDataTypes
{
    public class GetDataTypesQueryHandler : IRequestHandler<GetDataTypesQuery, List<DataTypesDto>>
	{
		private readonly IMapper _mapper;
		private readonly IDataTypeRepository _dataTypeRepository;

        public GetDataTypesQueryHandler(IMapper mapper, IDataTypeRepository dataTypeRepository)
        {
			_mapper = mapper;
			_dataTypeRepository = dataTypeRepository;
		}
        public async Task<List<DataTypesDto>> Handle(GetDataTypesQuery request, CancellationToken cancellationToken)
		{
			var dataTypes = await _dataTypeRepository.GetAllAsync();
			var data = _mapper.Map<List<DataTypesDto>>(dataTypes);

			return data;
		}
	}
}
