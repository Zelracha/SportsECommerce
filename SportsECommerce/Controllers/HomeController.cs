using Microsoft.AspNetCore.Mvc;
using SportsECommerce.Models.Repository;
using System.Diagnostics;

namespace SportsECommerce.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        // specifies four products per page
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int productPage = 1)
        {
            return View(repository.Products
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize));
        }
    }
}
