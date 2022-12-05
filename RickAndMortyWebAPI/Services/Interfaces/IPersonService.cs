using RickAndMortyWebAPI.DTOs;
using RickAndMortyWebAPI.Models;

namespace RickAndMortyWebAPI.Services.Interfaces;

public interface IPersonService
{
    Task<IResult<bool>> CheckPersonAsync(CheckPersonRequest request);
    Task<IResult<CharacterResponse>> GetPersonAsync(string name);
}
