using Microsoft.EntityFrameworkCore;
using Nlayer.Core;

namespace Nlayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
