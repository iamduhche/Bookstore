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
        [Display(Name = "Year of Release")]
        public int? YearOfRelease { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Number of Pages")]
        public int? NumberOfPages { get; set; }


        [Required]
        [Display(Name = "Type of Cover")]
        public string TypeOfCover { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        [Required]
        [Range(0.00, 1000.00,
            ErrorMessage = "Price must be a positive number and less than {2}$.")]
        public decimal Price { get; init; }

        [Display(Name = "Genre")]
        public int GenreId { get; init; }
        public IEnumerable<BookGenreModel> Genres { get; set; } = new List<BookGenreModel>();

    }
}
