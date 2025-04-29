using Base.Api.Extensions;
using Base.Application.Contracts.Users;
using Base.Application.Services.Interfaces;
using Base.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Authorize(Roles = DefaultRoles.Admin.Name)]
public class UsersController(IUserService _userService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _userService.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Add(CreateUserRequest request)
    {
        var result = await _userService.AddAsync(request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{email}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Delete(string email)
    {
        var result = await _userService.DeleteAsync(email);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
}
