using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.SegmentData.Commands.CreateSegmentData;
using DocumentRegister.Application.Features.SegmentData.Commands.DeleteSegmentData;
using DocumentRegister.Application.Features.SegmentData.Commands.UpdateSegmentData;
using DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentData;
using DocumentRegister.Application.Features.SegmentData.Queries.GetSegmentDataDetails;
using DocumentRegister.Core.DTOs.SegmentData;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SegmentDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SegmentDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<SegmentDataController>
        [HttpGet]
        public async Task<ActionResult<List<SegmentDataDto>>> GetSegmentData()
        {
            var segmentDataList = await _mediator.Send(new GetSegmentDataQuery());
            return Ok(segmentDataList);
        }

        // GET api/<SegmentDataController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SegmentDataDetailsDto>> GetSegmentData(int id)
        {
            var segmentData = await _mediator.Send(new GetSegmentDataDetailsQuery(id));
            return Ok(segmentData);
        }

        // POST api/<SegmentDataController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response<int>>> PostSegmentData([FromBody] CreateSegmentDataCommand segmentData)
        {
            var segmentDataId = await _mediator.Send(segmentData);
            var response = new Response<int>
            {
                Success = true,
                Data = segmentDataId
            };
            return Ok(response);
        }

        // PUT api/<SegmentDataController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutSegmentData(UpdateSegmentDataCommand segmentData)
        {
            await _mediator.Send(segmentData);
            return NoContent();
        }

        // DELETE api/<SegmentDataController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteSegmentData(int id)
        {
            var command = new DeleteSegmentDataCommand { SegmentDataId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
