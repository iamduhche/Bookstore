using System.ComponentModel.DataAnnotations;
using static BookstoreCafe.Data.DataConstants.Genre;

namespace BookstoreCafe.Data.Entities
{
    public class Genre
    {
        public int Id { get; init; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

}