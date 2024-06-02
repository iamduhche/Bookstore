using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.ShoppingCarts.Models
{
    public class ShoppingCartItemModel
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public decimal BookPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => BookPrice * Quantity;
    }
}
