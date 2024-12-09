using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories
{
    public interface ICharacterSpeciesRepository
    {
        IEnumerable<CharacterSpecies> GetCharactersSpecies();
        CharacterSpecies GetCharacterSpecies(int id);
        CharacterSpecies Create(CharacterSpecies character);
        CharacterSpecies Update(CharacterSpecies character);
        CharacterSpecies Delete(int id);
    }
}
