using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Data.Seeds
{
    internal class ProdudctSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem 1",
                Price = 100,
                Stock = 10,
                CreatedDate = DateTime.Now
            });
            builder.HasData(new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem 2",
                Price = 200,
                Stock = 20,
                CreatedDate = DateTime.Now
            });
            builder.HasData(new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem 3",
                Price = 50,
                Stock = 50,
                CreatedDate = DateTime.Now
            });
            builder.HasData(new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Kitap 1",
                Price = 900,
                Stock = 8,
                CreatedDate = DateTime.Now
            });
            builder.HasData(new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Kitap 2",
                Price = 1000,
                Stock = 6,
                CreatedDate = DateTime.Now
            });
            builder.HasData(new Product
            {
                Id = 6,
                CategoryId = 3,
                Name = "Defter 1",
                Price = 600,
                Stock = 12,
                CreatedDate = DateTime.Now
            });
        }
    }
}
