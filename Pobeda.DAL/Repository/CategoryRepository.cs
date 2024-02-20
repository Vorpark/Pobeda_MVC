using Pobeda.DAL.Data;
using Pobeda.DAL.Repository.IRepository;
using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
