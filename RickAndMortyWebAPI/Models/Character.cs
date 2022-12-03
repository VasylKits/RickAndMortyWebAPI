using RickAndMortyWebAPI.Enums;

namespace RickAndMortyWebAPI.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public string Species { get; set; }
    public string Type { get; set; }
    public Gender Gender { get; set; }
    public CharacterOrigin Origin { get; set; }
    public CharacterLocation Location { get; set; }
    public string Image { get; set; }
    public List<Episode> Episode { get; set; }
    public string Url { get; set; }
    public DateTime? CreatedDate { get; set; }
}
