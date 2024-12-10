using ApiHollowKnight.Arguments.Character;
using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
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
            var character = _repository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            var character = _repository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult Create([FromBody] InputCreateUpdateCharacters character)
        {
            var createdCharacter = _repository.Create(new Character(character.Name, character.Description, character.Gender, 
                                                      character.TypeId, null, character.SpeciesId, null, character.PlacesId, 
                                                      null, character.Health, character.Color, character.ImageUrl));

            return Ok(new OutputCharacters(createdCharacter.Id, createdCharacter.Name, createdCharacter.Description,
                                            createdCharacter.Gender, createdCharacter.TypeId, createdCharacter.SpeciesId, 
                                            createdCharacter.PlacesId, createdCharacter.Health, createdCharacter.Color, 
                                            createdCharacter.ImageURL));
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] InputCreateUpdateCharacters character)
        {
            var getCharacter = _repository.Get(id); 
             if (getCharacter is null)
            {
                return NotFound();
            }

            getCharacter.Name = character.Name;
            getCharacter.Description = character.Description;
            getCharacter.Gender = character.Gender;
            getCharacter.TypeId = character.TypeId;
            getCharacter.SpeciesId = character.SpeciesId;
            getCharacter.PlacesId = character.PlacesId;
            getCharacter.Health = character.Health;
            getCharacter.Color = character.Color;
            getCharacter.ImageURL = character.ImageUrl;

            var updateCharacter = _repository.Update(getCharacter);

            return Ok(new OutputCharacters(
                updateCharacter.Id,
                updateCharacter.Name,
                updateCharacter.Description,
                updateCharacter.Gender,
                updateCharacter.TypeId,
                updateCharacter.SpeciesId,
                updateCharacter.PlacesId,
                updateCharacter.Health,
                updateCharacter.Color,
                updateCharacter.ImageURL
                ));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _repository.Get(id);
            if (categoria is null)
            {
                return NotFound();
            }
            var categoriaExcluida = _repository.Delete(categoria);
            return Ok(categoriaExcluida);
        }
    }
}
