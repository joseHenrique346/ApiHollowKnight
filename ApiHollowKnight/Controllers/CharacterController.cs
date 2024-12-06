using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharactersRepository _repository;

        public CharacterController(ICharactersRepository repository)
        {
             _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get()
        {
            var character = _repository.GetCharacter().ToList();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            var character = _repository.GetCharacters(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Character character)
        {
            _repository.Create(character);
            return Ok(character);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Character character)
        {
            return Ok(_repository.Update(character));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_repository.Delete(id));
        }
    }
}
