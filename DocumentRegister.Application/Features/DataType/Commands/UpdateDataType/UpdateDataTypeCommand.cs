using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.DataType.Commands.UpdateDataType
{
	public class UpdateDataTypeCommand : IRequest<Unit>
	{
		public int DataTypeId { get; set; }
		public string Name { get; set; } = string.Empty;
    }
}
