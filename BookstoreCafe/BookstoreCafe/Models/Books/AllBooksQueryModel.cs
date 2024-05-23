using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Models.Books
{
    public class AllBooksQueryModel
    {
        public const int BooksPerPage = 3;
        public string Genre { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;
        public BookSorting Sorting { get; init; }
        public int CurrentPage { get; init; } = 1;
        public int TotalBooksCount { get; set; }

        public IEnumerable<string> Genres { get; set; } = new List<string>();

        public IEnumerable<BookViewModel> Books { get; set; } = new List<BookViewModel>();
    }
}