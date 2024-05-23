using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Models.Books
{
    public class BookViewModel
    {
        public int Id { get; init; }
        public string Title { get; init; } = null!;
        public string Author { get; init; } = null!;
        
        [DisplayName("Image URL")]
        public string ImageUrl { get; init; } = null!; 
    }
}
