using DocumentRegister.Application.Features.Status.Commands.CreateStatus;
using DocumentRegister.Application.Features.Status.Commands.DeleteStatus;
using DocumentRegister.Application.Features.Status.Commands.UpdateStatus;
using DocumentRegister.Application.Features.Status.Queries.GetStatusDetails;
using DocumentRegister.Application.Features.Status.Queries.GetStatuses;
using DocumentRegister.Core.DTOs.Status;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostStatus(CreateStatusCommand status)
        {
            var response = await _mediator.Send(status);
            //return CreatedAtAction(nameof(GetStatus) , new { id = response });
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
