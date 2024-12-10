using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterSpeciesController : ControllerBase
    {

        private readonly ICharacterSpeciesRepository _repository;

        public CharacterSpeciesController(ICharacterSpeciesRepository repository)
        {
             _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CharacterSpecies>> Get()
        {
            var character = _repository.GetCharactersSpecies().ToList();
            return Ok(character);
        }
         
        [HttpGet("{id}")]
        public ActionResult<CharacterSpecies> Get(int id)
        {
            var character = _repository.GetCharacterSpecies(id);

            return Ok(character);
        }

        [HttpPost]
        public ActionResult Post(CharacterSpecies character)
        {
            return Ok(_repository.Create(character));
        }

        [HttpPut]
        public ActionResult Put(CharacterSpecies character)
        {
            return Ok(_repository.Update(character));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_repository.Delete(id));
        }
    }
}
