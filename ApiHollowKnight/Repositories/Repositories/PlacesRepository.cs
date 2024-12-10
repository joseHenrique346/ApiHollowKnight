using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class PlacesRepository : IPlacesRepository
    {
        private readonly AppDbContext _context;
        public PlacesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Place> GetPlaces()
        {
            return _context.Places.ToList();
        }

        public Place GetPlace(int id)
        {
            var place = _context.Places.FirstOrDefault(p => p.PlaceId == id);
            if (place is null)
            {
                throw new ArgumentException(nameof(place));
            }
            return place;
        }

        public Place Create(Place place)
        {
            if (place is null)
            {
                throw new ArgumentException(nameof(place));
            }
            _context.Add(place);
            _context.SaveChanges();
            return place;
        }
        public Place Update(Place place)
        {
            if (place is null)
            {
                throw new ArgumentException(nameof(place));
            }

            _context.Entry(place).State = EntityState.Modified;
            _context.SaveChanges();
            return place;
        }

        public Place Delete(int id)
        {
            var place = _context.Places.FirstOrDefault(p => p.PlaceId == id);
            if (place is null)
            {
                throw new ArgumentException(nameof(place));
            }

            _context.Remove(place);
            _context.SaveChanges();
            return place;
        }

    }
}
