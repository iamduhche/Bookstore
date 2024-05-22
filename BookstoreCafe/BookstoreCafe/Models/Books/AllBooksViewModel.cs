namespace BookstoreCafe.Models.Books
{
    public class AllBooksViewModel
    {
        public IEnumerable<BookDetailsViewModel> Books { get; set; }
            = new List<BookDetailsViewModel>();
    }
}