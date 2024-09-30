using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.MediaType.Commands.CreateMediaType;
using DocumentRegister.Application.Features.MediaType.Commands.DeleteMediaType;
using DocumentRegister.Application.Features.MediaType.Commands.UpdateMediaType;
using DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypeDetails;
using DocumentRegister.Application.Features.MediaType.Queries.GetMediaTypes;
using DocumentRegister.Core.DTOs.MediaType;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class MediaTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MediaTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/MediaTypes
        [HttpGet]
        public async Task<ActionResult<List<MediaTypesDto>>> GetMediaTypes()
        {
            var dataTypes = await _mediator.Send(new GetMediaTypesQuery());
            return Ok(dataTypes);
        }

        // GET: api/MediaTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MediaTypeDetailsDto>> GetMediaType(int id)
        {
            var dataType = await _mediator.Send(new GetMediaTypeDetailsQuery(id));
            return Ok(dataType);
        }

        // PUT: api/MediaTypes/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutMediaType(UpdateMediaTypeCommand dataType)
        {
            await _mediator.Send(dataType);
            return NoContent();
        }

        // POST: api/MediaTypes
        [HttpPost]
        public async Task<ActionResult<Response<int>>> PostMediaType(CreateMediaTypeCommand mediaType)
        {
            var mediaTypeId = await _mediator.Send(mediaType);
            var response = new Response<int>
            {
                Success = true,
                Data = mediaTypeId
            };
            return Ok(response);
        }

        // DELETE: api/MediaTypes/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteMediaType(int id)
        {
            var command = new DeleteMediaTypeCommand { MediaTypeId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
