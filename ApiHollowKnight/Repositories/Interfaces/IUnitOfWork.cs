using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
namespace ApiHollowKnight.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICharactersRepository CharacterRepository { get; }
        ICharacterSpeciesRepository CharacterSpeciesRepository { get; }
        ICharacterTypeRepository CharacterTypeRepository { get; }
        IPlacesRepository PlacesRepository { get; }
        //IRepository<Character> CharacterRepository { get; }
        //IRepository<CharacterSpecies> CharacterSpeciesRepository { get; }
        //IRepository<CharacterType> CharacterTypeRepository { get; }
        //IRepository<Place> PlaceRepository { get; }
        void Commit();
    }
}