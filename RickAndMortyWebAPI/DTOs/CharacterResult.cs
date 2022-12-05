using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class CharacterResult
{
    [JsonPropertyName("results")]
    public List<CharacterResponse> Data { get; set; }
}