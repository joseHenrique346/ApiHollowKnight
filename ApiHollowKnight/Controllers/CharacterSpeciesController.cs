using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterSpeciesController : ControllerBase
    {

        private readonly IUnitOfWork _uof;

        public CharacterSpeciesController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CharacterSpecies>> Get()
        {
            var character = _uof.CharacterSpeciesRepository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<CharacterSpecies> Get(int id)
        {
            var character = _uof.CharacterSpeciesRepository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult Post(CharacterSpecies character)
        {
            var createdCharacter = _uof.CharacterSpeciesRepository.Create(character);
            _uof.Commit();
            return Ok(createdCharacter);
        }

        [HttpPut]
        public ActionResult Put(CharacterSpecies character)
        {
            var updatedCharacter = _uof.CharacterSpeciesRepository.Update(character);
            _uof.Commit();
            return Ok(updatedCharacter);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var deletedCharacter = _uof.CharacterSpeciesRepository.Delete(id);
            _uof.Commit();
            return Ok(deletedCharacter);
        }
    }
}
