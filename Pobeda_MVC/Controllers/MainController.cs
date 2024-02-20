using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

namespace Pobeda_MVC.Controllers
{
    public class MainController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetPopularProducts();
            return View(productList);
        }
    }
}
