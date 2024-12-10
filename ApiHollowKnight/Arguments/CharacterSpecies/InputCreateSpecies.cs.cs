namespace ApiHollowKnight.Arguments.CharacterSpecies
{
    public class InputCreateSpecies(int id, string name, string description)
    {
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
    }
}
