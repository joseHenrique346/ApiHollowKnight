using System.Text.Json.Serialization;
namespace ApiHollowKnight.Arguments.Character

{
    [method: JsonConstructor]
    public class InputUpdateCharacters(string name, string description, string gender, int typeId, int speciesId, int placesId, decimal health, string color, string imageUrl)
    {
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
        public string Gender { get; private set; } = gender;
        public int TypeId { get; private set; } = typeId;
        public int SpeciesId { get; private set; } = speciesId;
        public int PlacesId { get; private set; } = placesId;
        public decimal Health { get; private set; } = health;
        public string Color { get; private set; } = color;
        public string ImageUrl { get; private set; } = imageUrl;
    }
}