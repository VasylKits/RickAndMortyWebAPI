using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class CharacterLastLocationResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
