﻿using ApiHollowKnight.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Arguments.Character
{
    [method: JsonConstructor]
    public class InputCreateUpdateCharacters(int name, string description, string gender, int typeId, int speciesId, int placesId, decimal health, string color, string imageUrl)
    {
        public int Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string Gender { get; set; } = gender;
        public int TypeId { get; set; } = typeId;
        public int SpeciesId { get; set; } = speciesId;
        public int PlacesId { get; set; } = placesId;
        public decimal Health { get; set; } = health;
        public string Color { get; set; } = color;
        public string ImageUrl { get; set; } = imageUrl;
    }

}
