using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
