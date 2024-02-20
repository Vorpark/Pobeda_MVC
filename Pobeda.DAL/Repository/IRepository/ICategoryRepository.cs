using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
