using Microsoft.AspNetCore.Mvc;
using SportsECommerce.Models;
using System.Diagnostics;

namespace SportsECommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
