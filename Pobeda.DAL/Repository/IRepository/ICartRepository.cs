using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Repository.IRepository
{
    public interface ICartRepository : IRepository<Cart>
    {
        void Update(Cart cart);
    }
}
