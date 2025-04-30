using Base.Api.Extensions;
using Base.Application.Contracts.Nfc_Cards;
using Base.Application.Services.Interfaces;
using Base.Domain.Consts;
using Base.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class Nfc_CardsController(INfc_CardService nfc_CardService) : ControllerBase
{
    private readonly INfc_CardService _Nfc_CardService = nfc_CardService;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _Nfc_CardService.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _Nfc_CardService.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }
    [HttpPost("")]
    public async Task<IActionResult> Create([FromForm] Nfc_CardRequest request)
    {
        var result = await _Nfc_CardService.CreateAsync(request);

        return result.IsSuccess
           // ? CreatedAtAction(nameof(Get),new {id=result.Value.Id},result.Value)
           ? Ok(result.Value)
            : result.ToProblem();
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromForm] Nfc_CardRequest request)
    {
        var result = await _Nfc_CardService.UpdateAsync(id, request);

        return result.IsSuccess ? NoContent() : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _Nfc_CardService.DeleteAsync(id);

        return result.IsSuccess ? NoContent() : result.ToProblem();
    }

}
