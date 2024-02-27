using Microsoft.EntityFrameworkCore;
using Pobeda.DAL.Data;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;
using System.Linq.Expressions;

namespace Pobeda.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
        public IEnumerable<Product> GetPopularProducts()
        {
            //Реализация фильтра продвижения продукта
            IQueryable<Product> query = dbSet.Take(12).Include(x => x.SubCategory).ThenInclude(y => y.Category);
            return query.ToList();
        }
        public IEnumerable<Product> GetAllFilter(Expression<Func<Product, bool>> filter)
        {
            IQueryable<Product> query = dbSet;
            return query.Where(filter).Include(x => x.SubCategory).Include(x => x.Tags).ToList();
        }
    }
}
