using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    public class CatalogController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
