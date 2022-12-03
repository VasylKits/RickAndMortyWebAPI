using RickAndMortyWebAPI.Enums;
using RickAndMortyWebAPI.Models;

namespace RickAndMortyWebAPI.DTOs;

public class CharacterResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public string Species { get; set; }
    public string Type { get; set; }
    public Gender Gender { get; set; }
    public CharacterOriginResponse Origin { get; set; }
    public CharacterLocationResponse Location { get; set; }
    public string Image { get; set; }
    public List<EpisodeResponse> Episode { get; set; }
    public string Url { get; set; }
    public DateTime? CreatedDate { get; set; }
}
