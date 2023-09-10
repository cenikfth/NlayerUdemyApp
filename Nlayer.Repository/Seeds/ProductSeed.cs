using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core;

namespace Nlayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product()
            { 
                Id = 1, 
                Name = "Kalem 1",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null,
            },
            new Product()
            {
                Id = 2,
                Name = "Kalem 2",
                CategoryId = 1,
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null,
            },
            new Product()
            {
                Id = 3,
                Name = "Kalem 3",
                CategoryId = 1,
                Price = 300,
                Stock = 40,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null,
            }, new Product()
            {
                Id = 4,
                Name = "Kitap 1",
                CategoryId = 2,
                Price = 100,
                Stock = 50,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null,
            }, new Product()
            {
                Id = 5,
                Name = "Kitap 2",
                CategoryId = 2,
                Price = 1300,
                Stock = 520,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null,
            });
        }
    }
}
