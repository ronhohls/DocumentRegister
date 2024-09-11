using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.DataType.Commands.DeleteDataType
{
	public class DeleteDataTypeCommand : IRequest<Unit>
	{
		public int DataTypeId { get; set; }
    }
}
