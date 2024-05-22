using Microsoft.AspNetCore.Mvc;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;


namespace Pobeda_MVC.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = _unitOfWork.Cart.Get(x => x.Id == 1, "Products");
            cart.Products ??= new List<Product>();
            _unitOfWork.Cart.Update(cart);
            _unitOfWork.Save();
            return View(cart);
        }

        [HttpGet]
        [Route("add-product-to-cart/{productId}")]
        public IActionResult AddProductToCart(int productId)
        {
            var product = _unitOfWork.Product.Get(x => x.Id == productId);
            var cart = _unitOfWork.Cart.Get(x => x.Id == 1);
            if (cart.Products == null)
                cart.Products = new List<Product>();
            cart.Products.Add(product);
            _unitOfWork.Cart.Update(cart);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete-product-from-cart/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var cart = _unitOfWork.Cart.Get(x => x.Id == 1, "Products");
            var product = cart.Products.FirstOrDefault(x => x.Id == productId);
            cart.Products.Remove(product);
            _unitOfWork.Cart.Update(cart);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete-all-products-from-cart")]
        public IActionResult DeleteAllProducts()
        {
            var cart = _unitOfWork.Cart.Get(x => x.Id == 1, "Products");
            cart.Products.Clear();
            _unitOfWork.Cart.Update(cart);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
