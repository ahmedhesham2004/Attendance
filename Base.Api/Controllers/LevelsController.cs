using Base.Api.Extensions;
using Base.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class LevelsController(ILevelService level) : ControllerBase
{
    private readonly ILevelService _Level = level;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _Level.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _Level.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }
}
