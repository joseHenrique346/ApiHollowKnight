namespace ApiHollowKnight.Arguments.Places
{
    public class OutputPlaces(int id, string location, string imageURL)
    {
        public int Id { get; private set; } = id;
        public string Location { get; private set; } = location;
        public string ImageURL { get; private set; } = imageURL;
    }
}
