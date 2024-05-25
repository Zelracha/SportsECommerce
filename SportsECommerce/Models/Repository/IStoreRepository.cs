namespace SportsECommerce.Models.Repository
{
    public interface IStoreRepository
    {
        // IQueryable allows a collection of objects to be queried efficiently
        IQueryable<Product> Products { get; }
    }
}
