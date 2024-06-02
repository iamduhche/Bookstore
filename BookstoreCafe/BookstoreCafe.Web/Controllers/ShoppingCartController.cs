using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.ShoppingCarts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class ShoppingCartController : Controller
{
    private readonly IShoppingCartService _shoppingCartService;

    public ShoppingCartController(IShoppingCartService shoppingCartService)
    {
        _shoppingCartService = shoppingCartService;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var model = await _shoppingCartService.GetCart(userId);
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateQuantity(int bookId, int quantity)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _shoppingCartService.UpdateCartQuantity(userId, bookId, quantity);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> RemoveFromCart(int bookId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _shoppingCartService.RemoveFromCart(userId, bookId);
        return RedirectToAction("Index");
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> AddToCart(int bookId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        await _shoppingCartService.AddToCart(userId, bookId);
        return RedirectToAction("Index");
    }
}