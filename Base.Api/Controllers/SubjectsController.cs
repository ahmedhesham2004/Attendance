using Base.Api.Extensions;
using Base.Application.Contracts.Doctor;
using Base.Application.Contracts.Subjects;
using Base.Application.Services.Implementations;
using Base.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class SubjectsController(ISubjectService subjectService) : ControllerBase
{
    private readonly ISubjectService _SubjectService = subjectService;


    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _SubjectService.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _SubjectService.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }
    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create(SubjectRequest request)
    {
        var result = await _SubjectService.CreateAsync( request);
        return result.IsSuccess
           ? CreatedAtAction(nameof(Get), new { id = result.Value.Id }, result.Value)
          //?Ok(result.Value)
           : result.ToProblem();
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update([FromRoute] int id, SubjectRequest request)
    {
        var result = await _SubjectService.UpdateAsync(id, request);

        return result.IsSuccess ? NoContent() : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _SubjectService.DeleteAsync(id);

        return result.IsSuccess ? NoContent() : result.ToProblem();
    }
}
