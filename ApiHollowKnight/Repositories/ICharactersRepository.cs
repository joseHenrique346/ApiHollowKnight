using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories
{
    public interface ICharactersRepository
    {
        IEnumerable<Character> GetCharacters();
        Character GetCharacter(int id);
        Character Create(Character character);
        Character Update(Character character);
        Character Delete(int id);
    }
}
