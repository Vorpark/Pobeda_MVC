using Pobeda.Domain.Entity;

namespace Pobeda.Domain.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<Product> PopularProducts { get; set; }
    }
}
