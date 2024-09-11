using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using DocumentRegister.Application.Features.DataType.Queries.GetDataTypes;
using DocumentRegister.Application.Features.DataType.Queries.GetDataTypeDetails;
using DocumentRegister.Application.Features.DataType.Commands.CreateDataType;
using DocumentRegister.Application.Features.DataType.Commands.UpdateDataType;
using DocumentRegister.Application.Features.DataType.Commands.DeleteDataType;
using DocumentRegister.Core.DTOs.DataType;

namespace DocumentRegister.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class DataTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DataTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/DataTypes
        [HttpGet]
        public async Task<ActionResult<List<DataTypesDto>>> GetDataTypes()
        {
            var dataTypes = await _mediator.Send(new GetDataTypesQuery());
            return Ok(dataTypes);
        }

        // GET: api/DataTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataTypeDetailsDto>> GetDataType(int id)
        {
            var dataType = await _mediator.Send(new GetDataTypeDetailsQuery(id));

            if (dataType == null)
            {
                return NotFound();

			}
				
            return Ok(dataType);
        }

        // PUT: api/DataTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(400)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
		public async Task<IActionResult> PutDataType(UpdateDataTypeCommand dataType)
        {
            await _mediator.Send(dataType);
            return NoContent();
        }

        // POST: api/DataTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostDataType(CreateDataTypeCommand dataType)
        {
            var response = await _mediator.Send(dataType);
            //return CreatedAtAction(nameof(GetDataType) , new { id = response });
            return Ok(response);
        }

        // DELETE: api/DataTypes/5
        [HttpDelete("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<IActionResult> DeleteDataType(int id)
        {
            var command = new DeleteDataTypeCommand { DataTypeId = id};
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
