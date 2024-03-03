using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository.IRepository
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
        void Update(ProductTag productTag);
    }
}
