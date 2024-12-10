using System.Text.Json.Serialization;

namespace ApiHollowKnight.Arguments.Places
{
    [method: JsonConstructor]
    public class OutPutPlaces(int id, string name, string imageUrl, string description)
    {
        public int Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public string ImageURL { get; private set; } = imageUrl;
        public string Description { get; private set; } = description;
    }
}
