using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookstoreCafe.Data.DataConstants.Book;

namespace BookstoreCafe.Services.Books.Models
{
    public class BookFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; init; } = null!;

        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        public string Author { get; init; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; init; } = null!;

        [Required]
        [Range(YearOfReleaseMinRange, YearOfReleaseMaxRange)]
        [Display(Name = "Year of Release")]
        public int? YearOfRelease { get; set; }

        [Required]
        [Range(NumberOfPagesMinRange, NumberOfPagesMaxRange)]
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
