using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories
{
    public class CharacterRepository : ICharactersRepository
    {
        private readonly AppDbContext _context;

        public CharacterRepository(AppDbContext context)
        {
             _context = context;
        }

        //public IEnumerable<Characters> GetCharacter()
        //{
        //    return _context.
        //}

        //public Characters GetCharacters(int id)
        //{
        //    return _context.Characters.FirsOrDefault.
        //}


        public Characters Create(Characters character)
        {
            throw new NotImplementedException();
        }

        public Characters Update(Characters character)
        {
            throw new NotImplementedException();
        }

        public Characters Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
