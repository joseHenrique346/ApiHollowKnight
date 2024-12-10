﻿using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHollowKnight.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterTypeController : ControllerBase
    {
        private readonly ICharacterTypeRepository _repository;

        public CharacterTypeController(ICharacterTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<CharacterType> Get()
        {
            var character = _repository.GetAll();
            return Ok(character);
        }

        [HttpGet("{id}")]
        public ActionResult<CharacterType> Get(int id)
        {
            var character = _repository.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<CharacterType> Create(CharacterType character)
        {
            return Ok(_repository.Create(character));
        }

        [HttpPut]
        public ActionResult<CharacterType> Update(CharacterType character)
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
