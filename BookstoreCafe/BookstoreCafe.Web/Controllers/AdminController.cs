using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookstoreCafe.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IOrderService _orderService;

        public AdminController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var pendingOrdersCount = await _orderService.GetPendingOrdersCount();
            return View(pendingOrdersCount);
        }

        public async Task<IActionResult> Orders()
        {
            var orders = await _orderService.GetAllOrders();
            return View(orders);
        }

        public async Task<IActionResult> OrderDetails(int id)
        {
            var order = await _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, OrderStatus status)
        {
            await _orderService.UpdateOrderStatus(orderId, status);
            return RedirectToAction("Orders");
        }

        [HttpPost]
        public async Task<IActionResult> Deliver(int orderId)
        {
            await _orderService.RemoveOrder(orderId);
            return RedirectToAction("Orders");
        }
    }
}
