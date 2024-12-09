using ApiHollowKnight.Models;


namespace ApiHollowKnight.Repositories
{
    public class CharacterSpeciesRepository
    {
        private readonly AppDbContext _context;
        public CharacterSpeciesRepository(AppDbContext context)
        {
             _context = context;
        }

        public IEnumerable<CharacterSpecies> GetCharactersSpecies()
        {
            return _context.CharactersSpecies.ToList();
        }

        public  CharacterSpecies GetCharacterSpecies(int id)
        {
            var character = _context.CharactersSpecies.FirstOrDefault(p => p.);
            return
        }
    }
}
