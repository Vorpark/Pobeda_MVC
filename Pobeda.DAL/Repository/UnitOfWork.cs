using Pobeda.DAL.Data;
using Pobeda.DAL.Repository.IRepository;

namespace Pobeda.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductRepository Product { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IProductTagRepository ProductTag { get; private set; }
        public ICartRepository Cart { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Product = new ProductRepository(_db);
            Category = new CategoryRepository(_db);
            ProductTag = new ProductTagRepository(_db);
            Cart = new CartRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
