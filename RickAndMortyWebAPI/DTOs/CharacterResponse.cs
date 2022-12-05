using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class CharacterResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("species")]
    public string Species { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
    [JsonPropertyName("origin")]
    public CharacterOriginLocationResponse Origin { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }

}
