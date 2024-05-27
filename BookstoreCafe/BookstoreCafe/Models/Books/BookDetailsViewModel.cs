namespace BookstoreCafe.Models.Books
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int? YearOfRelease { get; set; }
        public int? NumberOfPages { get; set; }
        public string TypeOfCover { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }

}