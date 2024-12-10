using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories.Interfaces
{
    public interface ICharacterTypeRepository
    {
        IEnumerable<CharacterType> GetCharactersType();
        CharacterType GetCharacterType(int id);
        CharacterType Create(CharacterType characterType);
        CharacterType Update(CharacterType characterType);
        CharacterType Delete(int id);
    }
}
