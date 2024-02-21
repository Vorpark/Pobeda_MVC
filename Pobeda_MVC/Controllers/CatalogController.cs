using Microsoft.AspNetCore.Mvc;

namespace Pobeda_MVC.Controllers
{
    [Route("catalog")]
    public class CatalogController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("{categoryName}")]
        public IActionResult RedirectToCategory(string categoryName)
        {
            return View();
        }
        [HttpGet]
        [Route("{categoryName}/{subCategoryName}")]
        public IActionResult RedirectToSubCategory(string categoryName, string subCategoryName)
        {
            return View();
        }
    }
}
