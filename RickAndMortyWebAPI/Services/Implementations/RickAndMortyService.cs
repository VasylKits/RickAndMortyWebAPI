using RickAndMortyWebAPI.Common;
using RickAndMortyWebAPI.DTOs;
using RickAndMortyWebAPI.Services.Interfaces;
using System.Text.Json;

namespace RickAndMortyWebAPI.Services.Implementations;

public class RickAndMortyService : IRickAndMortyService
{
    private readonly IHttpClientFactory _httpClientFactory;
    public RickAndMortyService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IResult<CharacterResponse>> GetCharacterByNameAsync(string characterName)
    {
        try
        {
            var url = RickAndMortyUrl.CharacterUrl + $"/?name={characterName}";
            var result = await _httpClientFactory.CreateClient().GetAsync(url);

            if (!result.IsSuccessStatusCode)
            {
                var responseError = await result.Content.ReadAsStringAsync();

                return new Result<CharacterResponse>
                {
                    IsError = true,
                    ErrorMessage = responseError
                };
            }

            var response = await result.Content.ReadAsStringAsync();

            var characterResponse = JsonSerializer.Deserialize<CharacterResult>(response);

            return new Result<CharacterResponse>
            {
                Response = characterResponse.Data.FirstOrDefault()
            };
        }

        catch(Exception e)
        {
            return new Result<CharacterResponse>
            {
                IsError = true,
                ErrorMessage = e.Message
            };
        }
    }

    public async Task<IResult<EpisodeResponse>> GetEpisodeByNameAsync(string episodeName)
    {
        try
        {
            var url = RickAndMortyUrl.EpisodeUrl + $"/?name={episodeName}";
            var result = await _httpClientFactory.CreateClient().GetAsync(url);

            if (!result.IsSuccessStatusCode)
            {
                var responseError = await result.Content.ReadAsStringAsync();

                return new Result<EpisodeResponse>
                {
                    IsError = true,
                    ErrorMessage = responseError
                };
            }

            var response = await result.Content.ReadAsStringAsync();

            var episodeResponse = JsonSerializer.Deserialize<EpisodeResult>(response);

            return new Result<EpisodeResponse>
            {
                Response = episodeResponse.Data.FirstOrDefault()
            };
        }

        catch (Exception e)
        {
            return new Result<EpisodeResponse>
            {
                IsError = true,
                ErrorMessage = e.Message
            };
        }
    }
}
