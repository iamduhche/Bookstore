using BookstoreCafe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.ShoppingCarts.Models
{
    public class ShoppingCartModel
    {
        public List<ShoppingCartItemModel> Items { get; set; } = new List<ShoppingCartItemModel>();
        public decimal Total => Items.Sum(item => item.TotalPrice);
    }

}
