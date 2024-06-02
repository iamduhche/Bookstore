using BookstoreCafe.Data.Entities;
using BookstoreCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookstoreCafe.Services.ShoppingCarts.Models;

namespace BookstoreCafe.Services.ShoppingCarts
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly BookCafeDbContext _context;

        public ShoppingCartService(BookCafeDbContext context)
        {
            _context = context;
        }

        public async Task AddToCart(string userId, int bookId)
        {
            var cart = await _context.ShoppingCarts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new ShoppingCart { UserId = userId, Items = new List<ShoppingCartItem>() };
                _context.ShoppingCarts.Add(cart);
            }

            var cartItem = cart.Items.FirstOrDefault(i => i.BookId == bookId);
            if (cartItem == null)
            {
                cart.Items.Add(new ShoppingCartItem { BookId = bookId, Quantity = 1 });
            }
            else
            {
                cartItem.Quantity++;
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ShoppingCartItemModel>> GetCartItems(string userId)
        {
            return await _context.ShoppingCartItems
                .Where(i => i.ShoppingCart.UserId == userId)
                .Select(i => new ShoppingCartItemModel
                {
                    BookId = i.BookId,
                    Quantity = i.Quantity,
                    BookTitle = i.Book.Title,
                    BookPrice = i.Book.Price
                }).ToListAsync();
        }

        public async Task<ShoppingCartModel> GetCart(string userId)
        {
            var items = await GetCartItems(userId);
            return new ShoppingCartModel { Items = items.ToList() };
        }

        public async Task RemoveFromCart(string userId, int bookId)
        {
            var cart = await _context.ShoppingCarts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null) return;

            var cartItem = cart.Items.FirstOrDefault(i => i.BookId == bookId);
            if (cartItem != null)
            {
                cart.Items.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCartQuantity(string userId, int bookId, int quantity)
        {
            var cart = await _context.ShoppingCarts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null) return;

            var cartItem = cart.Items.FirstOrDefault(i => i.BookId == bookId);
            if (cartItem != null)
            {
                if (quantity > 0)
                {
                    cartItem.Quantity = quantity;
                }
                else
                {
                    cart.Items.Remove(cartItem);
                }
                await _context.SaveChangesAsync();
            }
        }


    }
}
