using RickAndMortyWebAPI.DTOs;
using RickAndMortyWebAPI.Models;
using RickAndMortyWebAPI.Services.Interfaces;
using System.Linq;

namespace RickAndMortyWebAPI.Services.Implementations;

public class PersonService : IPersonService
{
    private readonly IRickAndMortyService _rickAndMortyService;

    public PersonService(IRickAndMortyService rickAndMortyService)
    {
        _rickAndMortyService = rickAndMortyService;
    }

    public async Task<IResult<bool>> CheckPersonAsync(CheckPersonRequest request)
    {
        var characters = await _rickAndMortyService.GetCharacterByNameAsync(request.PersonName);

        if (characters.IsError)
            return new Result<bool> { IsError = true };

        var episodes = await _rickAndMortyService.GetEpisodeByNameAsync(request.EpisodeName);

        if (episodes.IsError)
            return new Result<bool> { IsError = true };

        var characterUrl = characters.Response.Url;
        var characterUrls = episodes.Response.Characters;

        if (characterUrls.Contains(characterUrl))
            return new Result<bool> { Response = true };

        return new Result<bool> { Response = false };

    }

    public async Task<IResult<CharacterResponse>> GetPersonAsync(string name)
    {
        return await _rickAndMortyService.GetCharacterByNameAsync(name);
    }
}
