using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class CharacterRepository(AppDbContext context) : Repository<Character>(context), ICharactersRepository { }
}
