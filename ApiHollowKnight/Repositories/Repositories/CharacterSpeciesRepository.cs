using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ApiHollowKnight.Repositories.Repositories
{
    public class CharacterSpeciesRepository(AppDbContext context) : Repository<CharacterSpecies>(context), ICharacterSpeciesRepository { }
}