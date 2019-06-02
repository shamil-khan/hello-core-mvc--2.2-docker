using Microsoft.EntityFrameworkCore;

namespace hello_core_mvc.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}