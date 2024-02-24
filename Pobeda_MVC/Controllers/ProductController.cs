using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

namespace Pobeda_MVC.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult Index(string categoryName, string subCategoryName, string name)
        {
            //Отображение недействительного translitName
            Product product = _unitOfWork.Product.Get(x => x.TranslitName == name, includeProperties: "Characteristics,SubCategory,Tags");
            product.SubCategory.Category = _unitOfWork.Category.Get(x => x.Id == product.SubCategory.CategoryId);
            return View(product);
        }
    }
}
