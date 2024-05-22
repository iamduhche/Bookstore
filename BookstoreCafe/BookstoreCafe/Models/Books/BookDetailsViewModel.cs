namespace BookstoreCafe.Models.Books
{
    public class BookDetailsViewModel
    {
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }

    }
}