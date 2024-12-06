using ApiHollowKnight.Models;
using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    //public DbSet<Character>? Characters { get; set; }
    //public DbSet<CharacterSpecies>? CharactersSpecies { get; set; }
    public DbSet<CharacterType>? CharactersTypes { get; set; }
    public DbSet<Place>? Places { get; set; }
}