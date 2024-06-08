using BookstoreCafe.Data.Entities;
using BookstoreCafe.Data.Enums;
using BookstoreCafe.Services.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Orders
{
    public interface IOrderService
    {
        Task PlaceOrder(string userId, CheckoutViewModel model);
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int orderId);
        Task UpdateOrderStatus(int orderId, OrderStatus status);
        Task<int> GetPendingOrdersCount();
        Task RemoveOrder(int orderId);
    }

}
