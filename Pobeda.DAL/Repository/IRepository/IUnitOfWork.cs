namespace Pobeda.DAL.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        void Save();
    }
}
