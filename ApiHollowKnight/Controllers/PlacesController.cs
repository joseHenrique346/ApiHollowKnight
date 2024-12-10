using ApiHollowKnight.Arguments;
using ApiHollowKnight.Arguments.Places;
using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlacesRepository _repository;

        public PlacesController(IPlacesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<Place> GetPlaces()
        {
            var character = _repository.GetPlaces().ToList();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<Place> GetPlace(int id)
        {
            var character = _repository.GetPlace(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<Place> Create(InputCreatePlaces inputCreatePlaces)
        {
            var createdPlace = _repository.Create(new Place { Location = inputCreatePlaces.Location, ImageURL = inputCreatePlaces.ImageURL });
            return Ok(new OutputPlaces(createdPlace.PlaceId, createdPlace.Location, createdPlace.ImageURL));
        }

        [HttpPut]
        public ActionResult<Place> Update(Place place)
        {
            return Ok(_repository.Update(place));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_repository.Delete(id));
        }
    }
}
