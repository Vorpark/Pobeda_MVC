using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
