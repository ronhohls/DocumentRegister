using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.SegmentCategory.Commands.CreateSegmentCategory;
using DocumentRegister.Application.Features.SegmentCategory.Commands.DeleteSegmentCategory;
using DocumentRegister.Application.Features.SegmentCategory.Commands.UpdateSegmentCategory;
using DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategories;
using DocumentRegister.Application.Features.SegmentCategory.Queries.GetSegmentCategoryDetails;
using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class SegmentCategoryController : ControllerBase
	{
		private readonly IMediator _mediator;

        public SegmentCategoryController(IMediator mediator)
        {
			_mediator = mediator;
		}

        // GET: api/<SegmentCategoryController>
        [HttpGet]
		public async Task<ActionResult<List<SegmentCategoriesDto>>> GetSegmentCategories()
		{
			var segmentCategories = await _mediator.Send(new GetSegmentCategoriesQuery());
			return Ok(segmentCategories);
		}

		// GET api/<SegmentCategoryController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<SegmentCategoryDetailsDto>> GetSegmentCategory(int id)
		{
			var segmentCategory = await _mediator.Send(new GetSegmentCategoryDetailsQuery(id));
			return Ok(segmentCategory);
		}

		// POST api/<SegmentCategoryController>
		[HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<Response<int>>> PostSegmentCategory([FromBody] CreateSegmentCategoryCommand segmentCategory)
        {
            var segmentCategoryId = await _mediator.Send(segmentCategory);
            var response = new Response<int>
            {
                Success = true,
                Data = segmentCategoryId
            };
            return Ok(response);
        }

		// PUT api/<SegmentCategoryController>/5
		[HttpPut("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(400)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<IActionResult> PutSegmentCategory(UpdateSegmentCategoryCommand segmentCategory)
		{
			await _mediator.Send(segmentCategory);
			return NoContent();
		}

		// DELETE api/<SegmentCategoryController>/5
		[HttpDelete("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<IActionResult> DeleteSegmentCategory(int id)
		{
			var command = new DeleteSegmentCategoryCommand { SegmentCategoryId = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
