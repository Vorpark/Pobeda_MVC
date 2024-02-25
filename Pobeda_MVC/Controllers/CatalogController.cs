using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

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
        public IActionResult Category(string categoryName, string subCategoryName)
        {
            return View();
        }

        [HttpGet]
        [Route("{categoryName}/{subCategoryName}/{productName}")]
        public IActionResult Product(string categoryName, string subCategoryName, string productName)
        {
            //Отображение недействительного маршрута
            Product product = _unitOfWork.Product.Get(x => x.TranslitName == productName, includeProperties: "Characteristics,SubCategory,Tags");
            product.SubCategory.Category = _unitOfWork.Category.Get(x => x.Id == product.SubCategory.CategoryId);
            return View(product);
        }
    }
}
