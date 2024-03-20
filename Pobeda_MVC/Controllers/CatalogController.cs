using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;
using Pobeda.Domain.ViewModels;
using Pobeda.Domain.Options;
using System.Drawing.Design;

namespace Pobeda_MVC.Controllers
{
    [Route("catalog")]
    public class CatalogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICollection<CategoryCheckBoxOption> _categoryCheckBox;
        public CatalogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _categoryCheckBox = new List<CategoryCheckBoxOption>()
            {
                new CategoryCheckBoxOption()
                {
                    IsChecked = false,
                    Value = "Состояние новый",
                    Description = "Новый"
                },
                new CategoryCheckBoxOption()
                {
                    IsChecked = false,
                    Value = "Состояние отличное",
                    Description = "Отличное"
                },
                new CategoryCheckBoxOption()
                {
                    IsChecked = false,
                    Value = "Состояние хорошее",
                    Description = "Хорошее"
                },
                new CategoryCheckBoxOption()
                {
                    IsChecked = false,
                    Value = "Состояние удовлетворительное",
                    Description = "Удовлетворительное"
                }
            };
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("{categoryName}")]
        public IActionResult Category(string categoryName, ICollection<string>? state)
        {
            var category = _unitOfWork.Category.Get(x => x.TranslitName == categoryName, includeProperties: "SubCategories,CategoryTags");
            List<Product> products = new();
            if(state?.Count() == 0 || state == null)
            {
                products = _unitOfWork.Product.GetAllFilter(x => x.CategoryId == category.Id).ToList();
            }
            else
            {
                foreach (var tag in state)
                {
                    var currentTag = _unitOfWork.ProductTag.Get(x => x.Name == tag);
                    var filteredProducts = _unitOfWork.Product.GetAllFilter(x => x.Tags.Contains(currentTag)).Where(y => y.CategoryId == category.Id);
                    products.AddRange(filteredProducts);
                }
            }
            var categoryVM = new CategoryVM
            {
                CategoryName = category.Name,
                TranslitCategoryName = category.TranslitName,
                BannerImageUrl = category.ImageUrl,
                FilterItems = category.CategoryTags,
                Products = products,
                CheckBoxes = _categoryCheckBox,
                State = state
            };
            return View(categoryVM);
        }

        [HttpGet]
        [Route("{categoryName}/{subCategoryName}")]
        public IActionResult Category(string categoryName, string subCategoryName, ICollection<string>? state)
        {
            var category = _unitOfWork.Category.Get(x => x.TranslitName == categoryName, includeProperties: "SubCategories,CategoryTags");
            var subCategory = category.SubCategories.Where(x => x.TranslitName == subCategoryName).First();
            List<Product> products = new();
            if (state?.Count() == 0 || state == null)
            {
                products = _unitOfWork.Product.GetAllFilter(x => x.SubCategoryId == subCategory.Id).ToList();
            }
            else
            {
                foreach (var tag in state)
                {
                    var currentTag = _unitOfWork.ProductTag.Get(x => x.Name == tag);
                    var filteredProducts = _unitOfWork.Product.GetAllFilter(x => x.Tags.Contains(currentTag)).Where(y => y.SubCategoryId == subCategory.Id);
                    products.AddRange(filteredProducts);
                }
            }
            var categoryVM = new CategoryVM
            {
                CategoryName = category.Name,
                TranslitCategoryName = category.TranslitName,
                SubCategoryName = subCategory.Name,
                BannerImageUrl = category.ImageUrl,
                FilterItems = category.CategoryTags,
                Products = products,
                CheckBoxes = _categoryCheckBox,
                State = state
            };
            return View(categoryVM);
        }

        [HttpPost]
        [Route("{categoryName}/{subCategoryName?}")]
        public IActionResult Category(CategoryVM categoryVM)
        {
            return RedirectToAction("Category", "Catalog", new { state = categoryVM.State});
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
