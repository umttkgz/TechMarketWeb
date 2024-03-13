using Microsoft.AspNetCore.Mvc;
using TechMarket.DataAccess.Data;
using TechMarket.Models;

namespace TechMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public SubCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<SubCategory> objCategoryList = _db.SubCategories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SubCategory obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Gösterim sırası ile ad aynı olamaz.");
            }
            if (ModelState.IsValid)
            {
                _db.SubCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
