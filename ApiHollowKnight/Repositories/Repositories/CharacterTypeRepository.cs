using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class CharacterTypeRepository(AppDbContext context) : Repository<CharacterType>(context), ICharacterTypeRepository { }
}