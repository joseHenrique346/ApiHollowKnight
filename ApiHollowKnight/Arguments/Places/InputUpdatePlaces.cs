using System.Text.Json.Serialization;
namespace ApiHollowKnight.Arguments.Places

{
    [method: JsonConstructor]
    public class InputUpdatePlaces(string name, string imageUrl, string description)
    {
        public string Name { get; private set; } = name;
        public string ImageURL { get; private set; } = imageUrl;
        public string Description { get; private set; } = description;
    }
}