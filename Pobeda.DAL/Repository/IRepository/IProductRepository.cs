using Pobeda.Domain.Entity;
using System.Linq.Expressions;

namespace Pobeda.DAL.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        public IEnumerable<Product> GetPopularProducts();
        public IEnumerable<Product> GetAllFilter(Expression<Func<Product, bool>> filter);
    }
}
