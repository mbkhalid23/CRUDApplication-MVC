using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication_MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
