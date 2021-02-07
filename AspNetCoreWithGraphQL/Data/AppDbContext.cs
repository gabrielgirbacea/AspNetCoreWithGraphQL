using AspNetCoreWithGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWithGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
    }
}
