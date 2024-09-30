using DocumentRegister.Application.Features.Document.Commands.DeleteDocument;
using DocumentRegister.Application.Features.Document.Queries.GetDocuments;
using DocumentRegister.Application.Features.Document.Queries.GetDocumentDetails;
using DocumentRegister.Core.DTOs.Document;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DocumentRegister.Application.Features.Document.Commands.CreateDocument;
using DocumentRegister.Application.Features.Document.Commands.UpdateDocument;
using DocumentRegister.API.Responses;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<DocumentController>
        [HttpGet]
        public async Task<ActionResult<List<DocumentsDto>>> GetDocuments()
        {
            var documents = await _mediator.Send(new GetDocumentsQuery());
            return Ok(documents);
        }

        // GET api/<DocumentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentDetailsDto>> GetDocument(int id)
        {
            var document = await _mediator.Send(new GetDocumentDetailsQuery(id));
            return Ok(document);
        }

        //// POST api/<DocumentController>
        //[HttpPost("old")]
        //[ProducesResponseType(201)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<Response<int>>> PostDocument([FromBody] CreateDocumentCommand document)
        //{
        //    var documentId = await _mediator.Send(document);
        //    var response = new Response<int>
        //    {
        //        Success = true,
        //        Data = documentId
        //    };
        //    return Ok(response);
        //}

        [HttpPost]
        public async Task<ActionResult<int>> CreateDocument2([FromBody] CreateDocumentDto documentDto)
        {
            var command = new CreateDocumentCommand { Document = documentDto };
            var documentId = await _mediator.Send(command);
            return Ok(documentId);
        }

            // PUT api/<DocumentController>/5
            [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutDocument(UpdateDocumentCommand document)
        {
            await _mediator.Send(document);
            return NoContent();
        }

        // DELETE api/<DocumentController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            var command = new DeleteDocumentCommand { DocumentId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
