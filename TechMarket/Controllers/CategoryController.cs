using Microsoft.AspNetCore.Mvc;

namespace TechMarket.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
