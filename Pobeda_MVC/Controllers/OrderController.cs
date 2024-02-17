using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
