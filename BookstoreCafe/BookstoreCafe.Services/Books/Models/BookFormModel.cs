using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Books.Models
{
    public class BookFormModel
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; init; } = null!;

        [Required]
        [StringLength(100)]
        public string Author { get; init; } = null!;

        [Required]
        [StringLength(2500)]
        public string Description { get; init; } = null!;

        [Required]
        [Range(1000, 9999)]
        public int? YearOfRelease { get; set; }

        [Required]
        [Range(1, 10000)]
        public int? NumberOfPages { get; set; }


        [Required]
        public string TypeOfCover { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        [Required]
        [Range(0.00, 100.00,
            ErrorMessage = "Price per month must be a positive number and less than {2} leva.")]
        [Display(Name = "Price Per Month")]
        public decimal Price { get; init; }

        [Display(Name = "Genre")]
        public int GenreId { get; init; }
        public IEnumerable<BookGenreModel> Genres { get; set; } = new List<BookGenreModel>();

    }
}
