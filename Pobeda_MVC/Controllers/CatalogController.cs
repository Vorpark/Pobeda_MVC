using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;
using Pobeda.Domain.ViewModels;

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
            //Отображение недействительного маршрута
            var category = _unitOfWork.Category.Get(x => x.TranslitName == categoryName, includeProperties: "SubCategories,CategoryTags");
            var products = _unitOfWork.Product.GetAllFilter(x => x.CategoryId == category.Id);
            var categoryVM = new CategoryVM
            {
                CategoryName = category.Name,
                TranslitCategoryName = category.TranslitName,
                BannerImageUrl = category.ImageUrl,
                FilterItems = category.CategoryTags,
                Products = products
            };
            return View(categoryVM);
        }

        [HttpGet]
        [Route("{categoryName}/{subCategoryName}")]
        public IActionResult Category(string categoryName, string subCategoryName)
        {
            var category = _unitOfWork.Category.Get(x => x.TranslitName == categoryName, includeProperties: "SubCategories,CategoryTags");
            var subCategory = category.SubCategories.Where(x => x.TranslitName == subCategoryName).First();
            var products = _unitOfWork.Product.GetAllFilter(x => x.SubCategoryId == subCategory.Id);
            var categoryVM = new CategoryVM
            {
                CategoryName = category.Name,
                TranslitCategoryName = category.TranslitName,
                SubCategoryName = subCategory.Name,
                BannerImageUrl = category.ImageUrl,
                FilterItems = category.CategoryTags,
                Products = products
            };
            return View(categoryVM);
        }

        [HttpGet]
        [Route("{categoryName}/{subCategoryName}/{productName}")]
        public IActionResult Product(string categoryName, string subCategoryName, string productName)
        {
            //Отображение недействительного маршрута
            Product product = _unitOfWork.Product.Get(x => x.TranslitName == productName, includeProperties: "Characteristics,SubCategory,Tags");
            product.SubCategory.Category = _unitOfWork.Category.Get(x => x.Id == product.CategoryId);
            return View(product);
        }
    }
}
