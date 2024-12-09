using ApiHollowKnight.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories
{
    public class CharacterTypeRepository : ICharacterTypeRepository
    {
        private readonly AppDbContext _context;

        public CharacterTypeRepository(AppDbContext context)
        {
             _context = context;
        }

        public IEnumerable<CharacterType> GetCharactersType()
        {
            return _context.CharactersTypes.ToList();
        }

        public CharacterType GetCharacterType(int id)
        {
            var character = _context.CharactersTypes.FirstOrDefault(p => p.CharacterTypeId == id);
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }
            return character;
        }

        public CharacterType Create(CharacterType character)
        {
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }

            _context.Add(character);
            _context.SaveChanges();
            return character;
        }

        public CharacterType Update(CharacterType character)
        {
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }

            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return character;
        }

        public CharacterType Delete(int id)
        {
            var character = _context.CharactersTypes.FirstOrDefault(p=>p.CharacterTypeId == id);
            if (character is null)
            {
                throw new ArgumentException(nameof(character));
            }
            _context.Remove(character);
            _context.SaveChanges();
            return character;
        }
    }
}
