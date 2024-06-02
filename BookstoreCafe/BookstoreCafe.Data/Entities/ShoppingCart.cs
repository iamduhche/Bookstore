using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Data.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
    }
}
