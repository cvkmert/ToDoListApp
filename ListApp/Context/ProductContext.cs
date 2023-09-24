using ListApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ListApp.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
