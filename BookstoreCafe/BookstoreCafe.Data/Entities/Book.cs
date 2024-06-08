using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static BookstoreCafe.Data.DataConstants.Book;


namespace BookstoreCafe.Data.Entities
{
    public class Book
    {
        public int Id { get; init; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        public string Author { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [Range(0, 999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        [Range(YearOfReleaseMinRange, YearOfReleaseMaxRange)]
        public int? YearOfRelease { get; set; }

        [Required]
        [Range(NumberOfPagesMinRange, NumberOfPagesMaxRange)]
        public int? NumberOfPages { get; set; }

        [Required]
        public string TypeOfCover { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; init; } = null!;
    }
}