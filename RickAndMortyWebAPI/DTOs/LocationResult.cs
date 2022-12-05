using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class LocationResult
{
    [JsonPropertyName("results")]
    public List<CharacterOriginLocationResponse> Data { get; set; }
}
