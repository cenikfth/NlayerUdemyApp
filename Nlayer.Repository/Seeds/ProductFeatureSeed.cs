using Microsoft.EntityFrameworkCore;
using Nlayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature 
            { 
                Id = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 100,
                ProductId = 1,
            },
            new ProductFeature 
            { 
                Id = 1,
                Color = "Mavi",
                Height = 300,
                Width = 400,
                ProductId = 2,
            });
        }
    }
}
