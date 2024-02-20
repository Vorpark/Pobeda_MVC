using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        public IEnumerable<Product> GetPopularProducts();
    }
}
