using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(i => i.ProductId);
            builder.Property(i => i.ProductId)
                   .IsRequired(true);
            builder.Property(n => n.Name)
                   .IsRequired(true)
                   .HasMaxLength(100);
            builder.HasIndex(n => n.Name)
                   .IsUnique();
            builder.Property(d => d.Description)
                   .HasColumnType("nvarchar(max)")
                   .IsRequired(false);
            builder.Property(p => p.Price)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 2)");
            builder.Property(c => c.Category)
                   .IsRequired(true);
            builder.Property(iu => iu.ImageUrl)
                    .HasColumnType("nvarchar(max)")
                   .IsRequired(false);
            builder.Property(di => di.Discount)
                   .IsRequired(false)
                   .HasDefaultValue(0);

            builder.HasOne<Category>(c => c.CategoryObject)
                .WithMany(p => p.ProductObjects)
                .HasForeignKey(ci => ci.Category);

            builder.HasMany<SaleProduct>(sp => sp.SaleProductObjects)
                .WithOne(p => p.ProductObject)
                .HasForeignKey(pfk => pfk.Product)
                .OnDelete(DeleteBehavior.Restrict);

            ProductData.SeedData(builder);
        }
    }
}
