using Microsoft.AspNetCore.Mvc;
using BookstoreCafe.Web.Models;
using BookstoreCafe.Data;
using BookstoreCafe.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace BookstoreCafe.Web.Controllers
{
    public class MenuController : Controller
    {

        private readonly BookCafeDbContext _context;

        public MenuController(BookCafeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string sortOrder, int? selectedCategory)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PriceSortParm"] = sortOrder == "price_asc" ? "price_desc" : "price_asc";

            var menuItems = from mi in _context.MenuItems select mi;

            if (selectedCategory.HasValue)
            {
                menuItems = menuItems.Where(mi => mi.CategoryId == selectedCategory.Value);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    menuItems = menuItems.OrderByDescending(mi => mi.Name);
                    break;
                case "price_asc":
                    menuItems = menuItems.OrderBy(mi => mi.Price);
                    break;
                case "price_desc":
                    menuItems = menuItems.OrderByDescending(mi => mi.Price);
                    break;
                default:
                    menuItems = menuItems.OrderBy(mi => mi.Name);
                    break;
            }

            var viewModel = new AllMenuItemsViewModel
            {
                MenuItems = menuItems.Select(mi => new MenuItemViewModel
                {
                    Id = mi.Id,
                    Name = mi.Name,
                    Ingredients = mi.Ingredients,
                    ImageUrl = mi.ImageUrl,
                    Price = mi.Price
                }).ToList(),
                SelectedCategory = selectedCategory,
                Categories = _context.MenuCategories.ToList()
            };

            return View(viewModel);
        }


        public IActionResult AddMenu()
        {
            ViewBag.MenuCategories = _context.MenuCategories.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMenu(AddMenuItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newItem = new MenuItem
                {
                    Name = model.Name,
                    Ingredients = model.Ingredients,
                    ImageUrl = model.ImageUrl,
                    Price = model.Price,
                    CategoryId = model.CategoryId
                };

                _context.MenuItems.Add(newItem);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var menuItem = _context.MenuItems.Find(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            var model = new MenuItemViewModel
            {
                Id = menuItem.Id,
                Name = menuItem.Name,
                Ingredients = menuItem.Ingredients,
                Price = menuItem.Price,
                ImageUrl = menuItem.ImageUrl,
                CategoryId = menuItem.CategoryId,
                Categories = _context.MenuCategories.ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MenuItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var menuItem = await _context.MenuItems.FindAsync(model.Id);
                if (menuItem == null)
                {
                    return NotFound();
                }
                menuItem.Name = model.Name;
                menuItem.Ingredients = model.Ingredients;
                menuItem.Price = model.Price;
                menuItem.ImageUrl = model.ImageUrl;
                menuItem.CategoryId = model.CategoryId;

                _context.Update(menuItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var menuItem = _context.MenuItems.Find(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            var model = new MenuItemViewModel
            {
                Id = menuItem.Id,
                Name = menuItem.Name,
                Ingredients = menuItem.Ingredients,
                Price = menuItem.Price,
                ImageUrl = menuItem.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(MenuItemViewModel model)
        {
            var menuItem = await _context.MenuItems.FindAsync(model.Id);
            if (menuItem == null)
            {
                return NotFound();
            }

            _context.MenuItems.Remove(menuItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}