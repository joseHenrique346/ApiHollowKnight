﻿using System.Text.Json.Serialization;
namespace ApiHollowKnight.Arguments.CharacterSpecies

{
    [method: JsonConstructor]
    public class InputCreateSpecies(int id, string name, string description)
    {
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
    }
}