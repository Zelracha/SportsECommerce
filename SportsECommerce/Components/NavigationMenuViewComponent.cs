using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using NuGet.Protocol.Core.Types;
using SportsECommerce.Models.Repository;

namespace SportsECommerce.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository _repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            _repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }

    }
}
