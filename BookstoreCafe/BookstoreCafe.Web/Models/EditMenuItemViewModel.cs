using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Web.Models
{
    public class EditMenuItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Ingredients { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
