using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Books.Models
{
    public class BookServiceModel
    {
        public int Id { get; init; }
        public string Title { get; init; } = null!;
        public string Author { get; init; } = null!;

        [DisplayName("Image URL")]
        public string ImageUrl { get; init; } = null!;

        public decimal Price { get; init; }
    }
}
