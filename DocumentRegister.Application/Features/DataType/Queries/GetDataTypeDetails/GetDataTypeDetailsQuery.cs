using DocumentRegister.Core.DTOs.DataType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
