using System.Linq;

namespace hello_core_mvc.Models
{
    public interface IRepository
    {
        IQueryable<Product> Products { get; } 
    }
}