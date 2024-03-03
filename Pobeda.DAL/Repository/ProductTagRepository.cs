using Pobeda.DAL.Data;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository
{
    public class ProductTagRepository : Repository<ProductTag>, IProductTagRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductTagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ProductTag obj)
        {
            _db.ProductTags.Update(obj);
        }
    }
}
