using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType
{
	public class UpdateMediaTypeCommand : IRequest<Unit>
	{
		public int MediaTypeId { get; set; }
		public string Description { get; set; } = string.Empty;
    }
}
