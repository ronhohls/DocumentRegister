using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.DataType.Commands.CreateDataType
{
	public class CreateDataTypeCommand : IRequest<int>
	{
		public string Name { get; set; } = string.Empty;
    }
}
