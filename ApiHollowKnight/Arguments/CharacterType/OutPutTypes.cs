using ApiHollowKnight.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiHollowKnight.Arguments.CharacterType
{
    public class OutPutTypes(int id, string? name, string? description)
    {
        public int Id { get; private set; } = id;


        public string? Name { get; private set; } = name;


        public string? Description { get; private set; } = description;
    }
}
