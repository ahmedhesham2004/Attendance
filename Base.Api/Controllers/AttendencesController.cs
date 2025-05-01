using Base.Api.Extensions;
using Base.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AttendencesController(IAttendenceService attendenceService) : ControllerBase
{
    private readonly IAttendenceService _attendenceService = attendenceService;

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _attendenceService.GetAllAsync();

        return Ok(result);
    }

    [HttpPost("")]
    public async Task<IActionResult> Seed()
    {
        await _attendenceService.SeedAsync();

        return Ok();
    }
}
