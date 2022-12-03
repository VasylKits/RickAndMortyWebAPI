using Microsoft.AspNetCore.Mvc;
using RickAndMortyWebAPI.Services.Interfaces;

namespace RickAndMortyWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RickAndMortyWebApiController : ControllerBase
{
	private readonly IRickAndMortyService _rickAndMortyService;
	public RickAndMortyWebApiController(IRickAndMortyService rickAndMortyService)
	{
		_rickAndMortyService = rickAndMortyService;
    }

    [HttpPost]
    public async Task<IActionResult> FindCharacterAsync()
    {
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetCharacterAsync()
    {
        return Ok();
    }
}
