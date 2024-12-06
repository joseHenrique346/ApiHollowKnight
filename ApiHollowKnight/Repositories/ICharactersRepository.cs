using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories
{
    public interface ICharactersRepository
    {
        IEnumerable<Characters> GetCharacter();
        Characters GetCharacters(int id);
        Characters Create(Characters character);
        Characters Update(Characters character);
        Characters Delete(int id);
    }
}
