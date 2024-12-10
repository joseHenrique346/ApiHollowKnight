using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class CharacterRepository : ICharactersRepository
    {
        private readonly AppDbContext _context;

        public CharacterRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Character> GetCharacters()
        {
            return _context.Characters.ToList();
        }

        public Character GetCharacter(int id)
        {
            var character = _context.Characters.FirstOrDefault(p => p.CharactersId == id);
            if (character is null)
            {
                throw new ArgumentNullException(nameof(character));
            }
            return character;
        }


        public Character Create(Character character)
        {
            if (character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Add(character);
            _context.SaveChanges();
            return character;
        }

        public Character Update(Character character)
        {
            if (character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return character;
        }

        public Character Delete(int id)
        {
            var character = _context.Characters.FirstOrDefault(c => c.CharactersId == id);
            if (character is null)
            {
                throw new ArgumentNullException(nameof(character));
            }
            _context.Characters.Remove(character);
            _context.SaveChanges();
            return character;
        }

    }
}
