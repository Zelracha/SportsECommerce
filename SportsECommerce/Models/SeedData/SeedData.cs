using SportsECommerce.Data;
using Microsoft.EntityFrameworkCore;
namespace SportsECommerce.Models.SeedData
{
    public static class SeedData
    {
        //
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak", 
                        Description = "A boat for one person", 
                        Category = "Water Sports", 
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Soccer Ball", 
                        Description = "FIFA-approved Ball", 
                        Category = "Soccer", 
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    });

                context.SaveChanges();

            }

        }
    }
}
