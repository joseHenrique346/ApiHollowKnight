using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterTypeController : ControllerBase
    {
        private readonly IUnitOfWork _uof;

        public CharacterTypeController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public ActionResult<CharacterType> Get()
        {
            var character = _uof.CharacterTypeRepository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<CharacterType> Get(int id)
        {
            var character = _uof.CharacterTypeRepository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<CharacterType> Create(CharacterType character)
        {
            var createdCharacter = _uof.CharacterTypeRepository.Create(character);
            _uof.Commit();
            return Ok(createdCharacter);
        }

        [HttpPut]
        public ActionResult<CharacterType> Update(CharacterType character)
        {
            var updatedCharacter = _uof.CharacterTypeRepository.Update(character);
            _uof.Commit();
            return Ok(updatedCharacter);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var deletedCharacter = _uof.CharacterTypeRepository.Delete(id);
            _uof.Commit();
            return Ok(deletedCharacter);
        }
    }
}
