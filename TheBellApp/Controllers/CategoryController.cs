using Microsoft.AspNetCore.Mvc;

namespace TheBellApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
