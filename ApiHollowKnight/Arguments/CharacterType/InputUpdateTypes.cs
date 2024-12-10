using System.Text.Json.Serialization;
namespace ApiHollowKnight.Arguments.CharacterType

{
    [method: JsonConstructor]
    public class InputUpdateTypes(int id, string? name, string? description)
    {
        public string? Name { get; private set; } = name;
        public string? Description { get; private set; } = description;
    }
}