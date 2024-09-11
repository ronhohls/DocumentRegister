using DocumentRegister.Core.DTOs.Status;
using MediatR;

namespace DocumentRegister.Application.Features.Status.Queries.GetStatusDetails
{
	public class GetStatusDetailsQuery : IRequest<StatusDetailsDto>
	{
		public int StatusId { get; set; }

		public GetStatusDetailsQuery(int id)
		{
			this.StatusId = id;
		}
	}
}
