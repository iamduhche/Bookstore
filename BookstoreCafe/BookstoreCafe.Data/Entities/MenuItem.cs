using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static BookstoreCafe.Data.DataConstants.MenuItem;

namespace BookstoreCafe.Data.Entities
{
    public class MenuItem
    {
        public int Id { get; init; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(IngredientsMaxLength, MinimumLength = IngredientsMinLength)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [Range(0, 999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; init; } = null!;

    }
}