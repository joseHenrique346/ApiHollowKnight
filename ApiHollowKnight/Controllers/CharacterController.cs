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
        private readonly IRepository<Character> _repository;

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
            var character = _repository.Get(c => c.Id == id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult Post([FromBody] InputCreateCharacters character)
        {
            var createdCharacter = _repository.Create(new Character { Name = character.Name, Description = character.Description, Gender = character.Gender,
                                                                        TypeId = character.TypeId, SpeciesId = character.SpeciesId, PlacesId = character.PlacesId,
                                                                        Health = character.Health, Color = character.Color, ImageURL = character.ImageUrl });

            return Ok(new OutputCharacters(createdCharacter.Id, createdCharacter.Name, createdCharacter.Description,
                                            createdCharacter.Gender, createdCharacter.TypeId, createdCharacter.SpeciesId, 
                                            createdCharacter.PlacesId, createdCharacter.Health, createdCharacter.Color, 
                                            createdCharacter.ImageURL));
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] InputUpdateCharacters character)
        {
            var getCharacter = _repository.Get(c => c.Id == id); 
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

            //return Ok(_repository.Update(character));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _repository.Get(c => c.Id == id);
            if (categoria is null)
            {
                return NotFound();
            }
            var categoriaExcluida = _repository.Delete(categoria);
            return Ok(categoriaExcluida);
        }
    }
}
