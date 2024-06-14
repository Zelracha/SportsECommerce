using Microsoft.AspNetCore.Mvc;
using SportsECommerce.Models.Repository;
using SportsECommerce.Models.ViewModel;
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

        public IActionResult Index(string? category, int productPage = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = repository.Products.
                Where(p => category == null || p.Category == category).
                OrderBy(p => p.Id).
                Skip((productPage - 1) * PageSize).
                Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Products.Count() : repository.Products
                    .Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            });
        }
    }
}
