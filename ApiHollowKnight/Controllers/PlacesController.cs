using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IUnitOfWork _uof;

        public PlacesController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public ActionResult<Place> GetPlaces()
        {
            var character = _uof.PlacesRepository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<Place> GetPlace(int id)
        {
            var character = _uof.PlacesRepository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<Place> Create(Place place)
        {
            var createdPlaces = _uof.PlacesRepository.Create(place);
            _uof.Commit();
            return Ok(createdPlaces);
        }

        [HttpPut]
        public ActionResult<Place> Update(Place place)
        {
            var updatedCharacter = _uof.PlacesRepository.Update(place);
            _uof.Commit();
            return Ok(updatedCharacter);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var deletedCharacter = _uof.PlacesRepository.Delete(id);
            _uof.Commit();
            return Ok(deletedCharacter);
        }
    }
}
