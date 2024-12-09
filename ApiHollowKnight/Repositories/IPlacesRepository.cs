using ApiHollowKnight.Models;

namespace ApiHollowKnight.Repositories
{
    public interface IPlacesRepository
    {
        IEnumerable<Place> GetPlaces();
        Place GetPlace(int id);
        Place Create(Place place);
        Place Update(Place place);
        Place Delete(int id);
    }
}
