using Microsoft.EntityFrameworkCore;
using SportsECommerce.Models;
namespace SportsECommerce.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
