namespace RickAndMortyWebAPI.Services.Interfaces;

public interface IResult<T>
{
    public T Response { get; set; }
}
