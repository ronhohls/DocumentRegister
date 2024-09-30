using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.Document.Commands.CreateBulkDocumentSegments;
using DocumentRegister.Application.Features.Document.Commands.CreateDocumentSegment;
using DocumentRegister.Application.Features.DocumentSegment.Commands.DeleteDocumentSegment;
using DocumentRegister.Application.Features.DocumentSegment.Commands.UpdateDocumentSegment;
using DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegmentDetails;
using DocumentRegister.Application.Features.DocumentSegment.Queries.GetDocumentSegments;
using DocumentRegister.Core.DTOs.DocumentSegment;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentSegmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentSegmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<DocumentSegmentController>
        [HttpGet]
        public async Task<ActionResult<List<DocumentSegmentsDto>>> GetDocumentSegments()
        {
            var documentSegments = await _mediator.Send(new GetDocumentSegmentsQuery());
            return Ok(documentSegments);
        }

        // GET api/<DocumentSegmentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentSegmentDetailsDto>> GetDocumentSegment(int id)
        {
            var documentSegment = await _mediator.Send(new GetDocumentSegmentDetailsQuery(id));
            return Ok(documentSegment);
        }

        // POST api/<DocumentSegmentController>
        [HttpPost("single")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response<int>>> PostDocumentSegment([FromBody] CreateDocumentSegmentCommand documentSegment)
        {
            var documentSegmentId = await _mediator.Send(documentSegment);
            var response = new Response<int>
            {
                Success = true,
                Data = documentSegmentId
            };
            return Ok(response);
        }
        //Post multiple document segments
        //POST api<DocumentSegmentController>
        [HttpPost("bulk")]
        [ProducesResponseType(typeof(Response<List<int>>), 200)]
        [ProducesResponseType(typeof(Response<List<int>>), 400)]
        [ProducesResponseType(typeof(Response<List<int>>), 404)]

        public async Task<ActionResult<Response<List<int>>>> PostDocumentSegments([FromBody] List<CreateDocumentSegmentCommand> documentSegments)
        {
            var documentSegmentIds = await _mediator.Send(new CreateBulkDocumentSegmentsCommand { DocumentSegments = documentSegments });
            var response = new Response<List<int>>
            {
                Success = true,
                Data = documentSegmentIds
            };
            return Ok(response);
        }


        // PUT api/<DocumentSegmentController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutDocumentSegment(UpdateDocumentSegmentCommand documentSegment)
        {
            await _mediator.Send(documentSegment);
            return NoContent();
        }

        // DELETE api/<DocumentSegmentController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteDocumentSegment(int id)
        {
            var command = new DeleteDocumentSegmentCommand { DocumentSegmentId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
