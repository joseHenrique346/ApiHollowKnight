﻿using System.Text.Json.Serialization;
namespace ApiHollowKnight.Arguments.CharacterType

{
    [method: JsonConstructor]
    public class OutPutTypes(int id, string? name, string? description)
    {
        public int Id { get; private set; } = id;
        public string? Name { get; private set; } = name;
        public string? Description { get; private set; } = description;
    }
}