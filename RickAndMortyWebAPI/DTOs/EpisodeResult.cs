using System.Text.Json.Serialization;

namespace RickAndMortyWebAPI.DTOs;

public class EpisodeResult
{
    [JsonPropertyName("results")]
    public List<EpisodeResponse> Data { get; set; }
}
