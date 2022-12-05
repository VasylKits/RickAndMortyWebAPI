using RickAndMortyWebAPI.DTOs;

namespace RickAndMortyWebAPI.Services.Interfaces;

public interface IRickAndMortyService
{
    Task<IResult<CharacterResponse>> GetCharacterByNameAsync(string characterName);
    Task<IResult<EpisodeResponse>> GetEpisodeByNameAsync(string episodeName);
    Task<IResult<List<CharacterOriginLocationResponse>>> GetLocationByNameAsync(string locationName);
}