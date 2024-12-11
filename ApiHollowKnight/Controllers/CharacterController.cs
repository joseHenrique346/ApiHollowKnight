﻿using ApiHollowKnight.Arguments.Character;
using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

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
            var createdCharacter = _repository.Create(new Character(" ", character.Description, character.Gender, 
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
            getCharacter = Converter.Convert(getCharacter, character);
            var updateCharacter = _repository.Update(getCharacter);
            return Ok((OutputCharacters)getCharacter);
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
    public static class Converter //criar a classe separada generica para todas
    {
        public static T Convert<T, T2>(T classe, T2 input)
    {
        (from i in typeof(T2).GetProperties()
         let value = i.GetValue(input)
         let property = typeof(T).GetProperty(i.Name)
         where property != null
         let _ = property.setProperty(classe, value)
         select true).ToList();
        return classe;
    }
    private static bool setProperty<T>(this PropertyInfo property, T classe, object value)
    {
        property.SetValue(classe, value);
        return true;
    }
}
}
