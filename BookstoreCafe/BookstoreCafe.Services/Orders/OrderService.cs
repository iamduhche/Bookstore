using BookstoreCafe.Data.Entities;
using BookstoreCafe.Data;
using BookstoreCafe.Services.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookstoreCafe.Data.Enums;

namespace BookstoreCafe.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly BookCafeDbContext _context;

        public OrderService(BookCafeDbContext context)
        {
            _context = context;
        }

        public async Task PlaceOrder(string userId, CheckoutViewModel model)
        {
            var cart = await _context.ShoppingCarts
                .Include(c => c.Items)
                .ThenInclude(i => i.Book)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null || !cart.Items.Any())
            {
                throw new InvalidOperationException("Cart is empty.");
            }

            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.UtcNow,
                DeliveryAddress = model.DeliveryAddress,
                DeliveryCity = model.DeliveryCity,
                DeliveryPostalCode = model.DeliveryPostalCode,
                Status = OrderStatus.Pending,
                OrderDetails = cart.Items.Select(item => new OrderDetail
                {
                    BookId = item.BookId,
                    Quantity = item.Quantity,
                    UnitPrice = item.Book.Price
                }).ToList()
            };

            order.CalculateTotalAmount();

            _context.Orders.Add(order);
            _context.ShoppingCartItems.RemoveRange(cart.Items);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Book)
                .ToListAsync();
        }


        public async Task<Order?> GetOrderById(int orderId)
        {   
            return await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Book)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task UpdateOrderStatus(int orderId, OrderStatus status)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null) return;

            order.Status = status;

            if (status == OrderStatus.Declined)
            {
                _context.Orders.Remove(order);
            }

            await _context.SaveChangesAsync();
        }


        public async Task<int> GetPendingOrdersCount()
        {
            return await _context.Orders.CountAsync(order => order.Status == OrderStatus.Pending);
        }

        public async Task RemoveOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }
    }
}
