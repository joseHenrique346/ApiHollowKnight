using ApiHollowKnight.Models;
using Microsoft.EntityFrameworkCore;


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
            var character = _context.CharactersSpecies.FirstOrDefault(p => p.CharactersSpeciesId == id);
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }
            return character;
        }

        public CharacterSpecies Create(CharacterSpecies character)
        {
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }

            _context.Add(character);
            _context.SaveChanges();

            return character;
        }

        public CharacterSpecies Update(CharacterSpecies character)
        {
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }

            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return character;
        }

        public CharacterSpecies Delete(int id)
        {
            var character = _context.CharactersSpecies.FirstOrDefault(c => c.CharactersSpeciesId == id);
            if (character is null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Remove(character);
            _context.SaveChanges();
            return character;
        }
    }
}
