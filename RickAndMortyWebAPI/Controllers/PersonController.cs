using Microsoft.AspNetCore.Mvc;
using RickAndMortyWebAPI.Models;
using RickAndMortyWebAPI.Services.Interfaces;

namespace RickAndMortyWebAPI.Controllers;

[Route("api/v1")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("person")]
    public async Task<IActionResult> GetPersonAsync(string personName)
    {
        var result = await _personService.GetPersonAsync(personName);

        if (result.IsError)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("check-person")]
    public async Task<IActionResult> CheckPersonAsync([FromBody] CheckPersonRequest request)
    {
        var result = await _personService.CheckPersonAsync(request);

        if (result.IsError)
            return NotFound();

        return Ok(result);
    }
}
