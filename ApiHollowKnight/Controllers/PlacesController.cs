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
            var character = _repository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<Place> GetPlace(int id)
        {
            var character = _repository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<Place> Create(Place place)
        {
            return Ok(_repository.Create(place));
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
