using System.ComponentModel.DataAnnotations.Schema;
namespace SportsECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        [Column(TypeName = "decimal(8, 2)")] // Column attribute to specify the SQL Data Type
        public decimal Price { get; set; }
        public string Category { get; set; } = String.Empty;
    }
}
