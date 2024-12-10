using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class PlacesRepository(AppDbContext context) : Repository<Place>(context)
    {
    }
}
