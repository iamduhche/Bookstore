using BookstoreCafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookstoreCafe.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() => View();
        public IActionResult About() => View();

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}