namespace RickAndMortyWebAPI.Services.Interfaces;

public interface IResult<T>
{
    public T Response { get; set; }
    public bool IsError { get; set; }
    public string ErrorMessage { get; set; }
}
