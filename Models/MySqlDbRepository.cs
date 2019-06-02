using System.Linq;

namespace hello_core_mvc.Models
{
    public class MySqlDbRepository : IRepository
    {
        private ProductDbContext context;

        public MySqlDbRepository(ProductDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> Products => this.context.Products;
    }
}