using DocumentRegister.Core.DTOs.DataType;
using MediatR;

namespace DocumentRegister.Application.Features.DataType.Queries.GetDataTypeDetails
{
	public class GetDataTypeDetailsQuery : IRequest<DataTypeDetailsDto>
	{
		public int DataTypeId { get; set; }

		public GetDataTypeDetailsQuery(int id)
		{
			this.DataTypeId = id;
		}
	}
}
