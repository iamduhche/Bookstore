using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BookstoreCafe.Data.Entities
{
    public class Book
    {
        public int Id { get; init; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = null!;

        [Required]
        [StringLength(2500)]
        public string Description { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [Range(0, 999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        [Range(1000, 9999)]
        public int? YearOfRelease { get; set; }

        [Required]
        [Range(1, 10000)]
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