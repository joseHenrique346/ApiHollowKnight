using System.Text.Json.Serialization;

namespace ApiHollowKnight.Arguments
{
    [method: JsonConstructor]
    public class InputCreatePlaces(string location, string imageURL)
    {
        public string Location { get; private set; } = location;
        public string ImageURL { get; private set; } = imageURL;
    }
}
