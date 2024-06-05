using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Web.Models
{
    public class AddMenuItemViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(1000)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
