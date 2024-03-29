using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace hello_core_mvc.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EnsurePopulated(
                app.ApplicationServices.GetRequiredService<ProductDbContext>()
            );

        }

        public static void EnsurePopulated(ProductDbContext context)
        {
            System.Console.WriteLine("Apply migrations ...");
            context.Database.Migrate();

            if(!context.Products.Any())
            {
                System.Console.WriteLine("Creating seed data ...");
                
                context.Products.AddRange(
                    new Product { Id = 1, Name = "Essential Docker for ASP.NET Core MVC", Category = "Books", Price = 250 },
                    new Product { Id = 2, Name = "Toy story 1", Category = "Movies", Price = 10 },
                    new Product { Id = 3, Name = "Toy story 2", Category = "Movies", Price = 15 },
                    new Product { Id = 4, Name = "Toy story 3", Category = "Movies", Price = 20 },
                    new Product { Id = 5, Name = "C# : The Complete Reference", Category = "Movies", Price = 150 },
                    new Product { Id = 6, Name = "GOF Design Patterns", Category = "Books", Price = 130 },
                    new Product { Id = 7, Name = "Enterprise Application design Patterns",  Category = "Books", Price = 150 },
                    new Product { Id = 8, Name = "Inception",  Category = "Movies", Price = 30 },
                    new Product { Id = 9, Name = "Scarface",  Category = "Movies", Price = 40 },
                    new Product { Id = 10, Name = "Scent of a Woman", Category = "Movies", Price = 5 },
                    new Product { Id = 11, Name = "Perfume", Category = "Movies", Price = 8 }
                );
                
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Seed data not required ...");
            }

        }
    }
}