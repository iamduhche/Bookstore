namespace BookstoreCafe.Data.Entities
{
    public class Genre
    {
        public int Id { get; init; }
        public string Name { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

}