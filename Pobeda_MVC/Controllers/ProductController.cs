using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

namespace Pobeda_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                //Отображение недействительного id
            }
            Product product = _unitOfWork.Product.Get(x => x.Id == id, includeProperties: "Characteristics,SubCategory,Tags");
            product.SubCategory.Category = _unitOfWork.Category.Get(x => x.Id == product.SubCategory.CategoryId);
            return View(product);
        }
    }
}
