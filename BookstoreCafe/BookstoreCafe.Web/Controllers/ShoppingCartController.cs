using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.Orders;
using BookstoreCafe.Services.Orders.Models;
using BookstoreCafe.Services.ShoppingCarts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class ShoppingCartController : Controller
{
    private readonly IShoppingCartService _shoppingCartService;
    private readonly IOrderService _orderService;

    public ShoppingCartController(IShoppingCartService shoppingCartService, IOrderService orderService)
    {
        _shoppingCartService = shoppingCartService;
        _orderService = orderService;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var model = await _shoppingCartService.GetCart(userId);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UpdateQuantity(int bookId, int quantity)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _shoppingCartService.UpdateCartQuantity(userId, bookId, quantity);
        return RedirectToAction("Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveFromCart(int bookId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _shoppingCartService.RemoveFromCart(userId, bookId);
        return RedirectToAction("Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddToCart(int bookId)
    {
        if (User.Identity.IsAuthenticated)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _shoppingCartService.AddToCart(userId, bookId);
            return RedirectToAction("Index");
        }
        else
        {
            return Unauthorized();
        }

    }

    public async Task<IActionResult> Checkout()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var cart = await _shoppingCartService.GetCart(userId);
        if (!cart.Items.Any())
        {
            return RedirectToAction("Index");
        }

        return View(new CheckoutViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Checkout(CheckoutViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _orderService.PlaceOrder(userId, model);

        return RedirectToAction("OrderConfirmation");
    }

    public IActionResult OrderConfirmation()
    {
        return View("OrderConfirmation");
    }
}