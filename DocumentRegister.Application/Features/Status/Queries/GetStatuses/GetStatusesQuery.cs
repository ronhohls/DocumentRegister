using DocumentRegister.Core.DTOs.Status;
using MediatR;

namespace DocumentRegister.Application.Features.Status.Queries.GetStatuses
{
	public class GetStatusesQuery : IRequest<List<StatusesDto>>
	{

	}
}
