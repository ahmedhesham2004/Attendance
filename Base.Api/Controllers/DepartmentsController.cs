using Base.Api.Extensions;
using Base.Application.Services.Interfaces;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class DepartmentsController(IDepartmentService departmentService) : ControllerBase
{
    private readonly IDepartmentService _DepartmentService = departmentService;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _DepartmentService.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _DepartmentService.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }
}
