using System.ComponentModel.DataAnnotations;
using static BookstoreCafe.Data.DataConstants.MenuItem;

namespace BookstoreCafe.Web.Models
{
    public class AddMenuItemViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(IngredientsMaxLength, MinimumLength = IngredientsMinLength)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
