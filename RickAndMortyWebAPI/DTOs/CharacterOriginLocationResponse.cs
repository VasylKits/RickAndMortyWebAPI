using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class CharacterOriginLocationResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("dimension")]
    public string Dimension { get; set; }
}
