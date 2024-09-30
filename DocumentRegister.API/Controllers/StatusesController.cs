using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.Status.Commands.CreateStatus;
using DocumentRegister.Application.Features.Status.Commands.DeleteStatus;
using DocumentRegister.Application.Features.Status.Commands.UpdateStatus;
using DocumentRegister.Application.Features.Status.Queries.GetStatusDetails;
using DocumentRegister.Application.Features.Status.Queries.GetStatuses;
using DocumentRegister.Core.DTOs.Status;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class StatusesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatusesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Statuses
        [HttpGet]
        public async Task<ActionResult<List<StatusesDto>>> GetStatuses()
        {
            var statuses = await _mediator.Send(new GetStatusesQuery());
            return Ok(statuses);
        }

        // GET: api/Statuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusDetailsDto>> GetStatus(int id)
        {
            var status = await _mediator.Send(new GetStatusDetailsQuery(id));

            if (status == null)
            {
                return NotFound();

            }

            return Ok(status);
        }

        // PUT: api/Statuses/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutStatus(UpdateStatusCommand status)
        {
            await _mediator.Send(status);
            return NoContent();
        }

        // POST: api/Statuses
        [HttpPost]
        public async Task<ActionResult<Response<int>>> PostStatus([FromBody] CreateStatusCommand status)
        {
            var statusId = await _mediator.Send(status);
            var response = new Response<int>
            {
                Success = true,
                Data = statusId
            };
            return Ok(response);
        }

        // DELETE: api/Statuses/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            var command = new DeleteStatusCommand { StatusId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
