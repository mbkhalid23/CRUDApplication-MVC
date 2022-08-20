using CRUDApplication_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication_MVC.Controllers
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
            var objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
