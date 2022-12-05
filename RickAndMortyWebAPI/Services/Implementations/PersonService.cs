using RickAndMortyWebAPI.DTOs;
using RickAndMortyWebAPI.Models;
using RickAndMortyWebAPI.Services.Interfaces;

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
        var characters = await _rickAndMortyService.GetCharacterByNameAsync(name);
        var character = characters.Response.Origin;

        var characterOriginName = characters.Response.Origin.Name;

        var locations = await _rickAndMortyService.GetLocationByNameAsync(characterOriginName);
        var findLocation = locations.Response.FirstOrDefault();

        character.Name = findLocation.Name;
        character.Type = findLocation.Type;
        character.Dimension = findLocation.Dimension;

        return characters;
    }
}