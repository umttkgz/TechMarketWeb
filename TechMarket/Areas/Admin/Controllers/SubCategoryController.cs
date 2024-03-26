using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechMarket.DataAccess.Data;
using TechMarket.DataAccess.Repository.IRepository;
using TechMarket.Models;
using TechMarket.Models.ViewModels;

namespace TechMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public SubCategoryController(AppDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<SubCategory> objCategoryList = _db.SubCategories.ToList();
            return View(objCategoryList);
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(SubCategory obj)
        //{
        //    if (obj.Name == obj.DisplayOrder.ToString())
        //    {
        //        ModelState.AddModelError("name", "Gösterim sırası ile ad aynı olamaz.");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _db.SubCategories.Add(obj);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        public IActionResult Upsert(int? id)
        {
            SubCategoryVM subCategoryVM = new()
            {
                CategoryList = _unitOfWork.Category
                .GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                SubCategory = new SubCategory()
            };
            if (id == null || id == 0)
            {
                //create
                return View(subCategoryVM);
            }
            else
            {
                //update
                subCategoryVM.SubCategory = _unitOfWork.SubCategory.Get(u => u.Id == id);
                return View(subCategoryVM);
            }

        }
        [HttpPost]
        public IActionResult Upsert(SubCategoryVM subCategoryVM)
        {
            if (ModelState.IsValid)
            {
                if (subCategoryVM.SubCategory.Id == 0)
                {
                    _unitOfWork.SubCategory.Add(subCategoryVM.SubCategory);
                }
                else
                {
                    _unitOfWork.SubCategory.Update(subCategoryVM.SubCategory);
                }
                _unitOfWork.Save();
                TempData["success"] = "Alt Kategori başarıyla oluşturuldu.";
                return RedirectToAction("Index");
            }
            else
            {
                subCategoryVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(subCategoryVM);
            }
        }
        //public IActionResult Create()
        //{
        //    SubCategoryVM subCategoryVM = new()
        //    {
        //        CategoryList = _unitOfWork.Category
        //        .GetAll().Select(u => new SelectListItem
        //        {
        //            Text = u.Name,
        //            Value = u.Id.ToString()
        //        }),
        //        SubCategory = new SubCategory()
        //    };
        //    return View(subCategoryVM);
        //}
        //[HttpPost]
        //public IActionResult Create(SubCategoryVM subcategoryVM)
        //{
            
        //    if (ModelState.IsValid)
        //    {
        //        _unitOfWork.SubCategory.Add(subcategoryVM.SubCategory);
        //        _unitOfWork.Save();
        //        TempData["success"] = "Alt kategori başarıyla oluşturuldu.";
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    SubCategoryVM subCategoryVM = new()
        //    {
        //        CategoryList = _unitOfWork.Category
        //        .GetAll().Select(u => new SelectListItem
        //        {
        //            Text = u.Name,
        //            Value = u.Id.ToString()
        //        }),
        //        SubCategory = new SubCategory()
        //    };
        //    if (subCategoryVM == null)
        //    {
        //        return NotFound();
        //    }
        //    subCategoryVM.SubCategory= _unitOfWork.SubCategory.Get(u => u.Id == id);
        //    return View(subCategoryVM);
        //}
        //[HttpPost]
        //public IActionResult Edit(Category obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _unitOfWork.Category.Update(obj);
        //        _unitOfWork.Save();
        //        TempData["success"] = "Kategori başarıyla düzenlendi.";
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        public IActionResult Delete(int? id)
        {
            //if (id == null || id == 0)
            //{
            //    return NotFound();
            //}
            //Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //if (categoryFromDb == null)
            //{
            //    return NotFound();
            //}
            //return View(categoryFromDb);

            var subCategoryToBeDeleted = _unitOfWork.SubCategory.Get(u => u.Id == id);
            if (subCategoryToBeDeleted == null)
            {
                return NotFound();
            }
            _unitOfWork.SubCategory.Remove(subCategoryToBeDeleted);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePOST(int? id)
        //{
        //    Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _unitOfWork.Category.Remove(obj);
        //    _unitOfWork.Save();
        //    TempData["success"] = "Kategori başarıyla silindi.";
        //    return RedirectToAction("Index");
        //}
    }
}
