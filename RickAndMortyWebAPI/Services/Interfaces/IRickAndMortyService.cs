using RickAndMortyWebAPI.DTOs;

namespace RickAndMortyWebAPI.Services.Interfaces;

public interface IRickAndMortyService
{
    Task<IResult<EpisodeResponse>> GetEpisodeByNameAsync(string episodeName);
    Task<IResult<CharacterResponse>> GetCharacterByNameAsync(string characterName);
}
