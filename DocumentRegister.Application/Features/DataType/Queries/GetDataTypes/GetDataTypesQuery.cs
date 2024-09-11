using DocumentRegister.Core.DTOs.DataType;
using MediatR;


namespace DocumentRegister.Application.Features.DataType.Queries.GetDataTypes
{
	public class GetDataTypesQuery : IRequest<List<DataTypesDto>>
	{
	}
}
