using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Utility;

namespace Pobeda_MVC.Controllers
{
    [Route("catalog")]
    public class CatalogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CatalogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("{categoryName}")]
        public IActionResult Category(string categoryName)
        {
            return View();
        }
        [HttpGet]
        [Route("{categoryName}/{subCategoryName}")]
        public IActionResult SubCategory(string categoryName, string subCategoryName)
        {
            return View();
        }
    }
}
