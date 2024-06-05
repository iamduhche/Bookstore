using BookstoreCafe.Data.Entities;

namespace BookstoreCafe.Web.Models
{
    public class AllMenuItemsViewModel
    {
        public IEnumerable<MenuItemViewModel> MenuItems { get; set; } = new List<MenuItemViewModel>();
        public int? SelectedCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
