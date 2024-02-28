using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
