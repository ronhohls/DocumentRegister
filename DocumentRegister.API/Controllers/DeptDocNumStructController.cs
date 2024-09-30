using DocumentRegister.API.Responses;
using DocumentRegister.Application.Features.DeptDocNumStruct.Commands.CreateDeptDocNumStruct;
using DocumentRegister.Application.Features.DeptDocNumStruct.Commands.DeleteDeptDocNumStruct;
using DocumentRegister.Application.Features.DeptDocNumStruct.Commands.UpdateDeptDocNumStruct;
using DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructDetails;
using DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetDeptDocNumStructs;
using DocumentRegister.Core.DTOs.DeptDocNumStruct;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentRegister.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        [Authorize]
        public class DeptDocNumStructController : ControllerBase
        {
            private readonly IMediator _mediator;

            public DeptDocNumStructController(IMediator mediator)
            {
                _mediator = mediator;
            }

            // GET: api/<DeptDocNumStructController>
            [HttpGet]
            public async Task<ActionResult<IEnumerable<DeptDocNumStructsDto>>> GetDeptDocNumStructs()
            {
                var deptdocNumStructs = await _mediator.Send(new GetDeptDocNumStructsQuery());
                return Ok(deptdocNumStructs);
            }

            // GET api/<DeptDocNumStructController>/5
            [HttpGet("{id}")]
            public async Task<ActionResult<DeptDocNumStructDetailsDto>> GetDeptDocNumStruct(int id)
            {
                var deptDocNumStruct = await _mediator.Send(new GetDeptDocNumStructDetailsQuery(id));
                return Ok(deptDocNumStruct);
            }

            // POST api/<DeptDocNumStructController>
            [HttpPost]
            [ProducesResponseType(201)]
            [ProducesResponseType(400)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<Response<int>>> PostDeptDocNumStruct([FromBody] CreateDeptDocNumStructCommand deptDocNumStruct)
            {
                var deptDocNumStructId = await _mediator.Send(deptDocNumStruct);
                var response = new Response<int>
                {
                    Success = true,
                    Data = deptDocNumStructId
                };
                return Ok(response);
            }

            // PUT api/<DeptDocNumStructController>/5
            [HttpPut("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(400)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesDefaultResponseType]
            public async Task<IActionResult> PutDeptDocNumStruct(UpdateDeptDocNumStructCommand deptDocNumStruct)
            {
                await _mediator.Send(deptDocNumStruct);
                return NoContent();
            }

            // DELETE api/<DeptDocNumStructController>/5
            [HttpDelete("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesDefaultResponseType]
            public async Task<IActionResult> DeleteDeptDocNumStruct(int id)
            {
                var command = new DeleteDeptDocNumStructCommand { DeptDocNumStructId = id };
                await _mediator.Send(command);
                return NoContent();
            }
        }
    }

