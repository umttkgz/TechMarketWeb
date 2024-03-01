using Microsoft.AspNetCore.Mvc;
using TechMarket.Data;
using TechMarket.Models;

namespace TechMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

    }
}
