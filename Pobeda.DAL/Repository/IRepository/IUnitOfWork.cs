namespace Pobeda.DAL.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IProductTagRepository ProductTag { get; }
        ICartRepository Cart { get; }
        void Save();
    }
}
