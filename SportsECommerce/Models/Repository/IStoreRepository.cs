namespace SportsECommerce.Models.Repository
{
    public class IStoreRepository
    {
        // IQueryable allows a collection of objects to be queried efficiently
        public IQueryable<Product> Products { get; set; }
    }
}
