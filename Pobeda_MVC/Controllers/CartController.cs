using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
