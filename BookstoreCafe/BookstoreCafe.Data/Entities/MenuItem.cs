using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Data.Entities
{
    public class MenuItem
    {
        public int Id { get; init; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(1000, MinimumLength = 4)]
        public string Ingredients { get; set; } = null;

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