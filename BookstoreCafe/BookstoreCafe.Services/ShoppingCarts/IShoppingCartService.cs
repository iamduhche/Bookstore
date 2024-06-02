using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.ShoppingCarts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.ShoppingCarts
{
    public interface IShoppingCartService
    {
        Task AddToCart(string userId, int bookId);
        Task<IEnumerable<ShoppingCartItemModel>> GetCartItems(string userId);
        Task<ShoppingCartModel> GetCart(string userId);
        Task RemoveFromCart(string userId, int bookId);
        Task UpdateCartQuantity(string userId, int bookId, int quantity);


    }
}
