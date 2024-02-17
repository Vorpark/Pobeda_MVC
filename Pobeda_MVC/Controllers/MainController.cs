using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
