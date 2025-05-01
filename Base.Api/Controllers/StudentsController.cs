using Base.Api.Extensions;
using Base.Application.Contracts.Students;
using Base.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class StudentsController(IStudentService studentService) : ControllerBase
{
    private readonly IStudentService _studentService = studentService;

    [HttpPost("")]
    public async Task<IActionResult> Add([FromBody] StudentRequest request)
    {
        var result = await _studentService.AddAsync(request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _studentService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("")]
    public async Task<IActionResult> Get()
    {
        var result = await _studentService.GetAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] StudentRequest request)
    {
        var result = await _studentService.UpdateAsync(id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _studentService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
