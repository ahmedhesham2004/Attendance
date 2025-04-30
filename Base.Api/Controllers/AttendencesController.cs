using Base.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AttendencesController(IAttendenceService attendenceService) : ControllerBase
{
    private readonly IAttendenceService _attendenceService = attendenceService;

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var result = await _studentService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
}
