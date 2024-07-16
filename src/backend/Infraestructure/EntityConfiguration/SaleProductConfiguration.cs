using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfiguration
{
    public class SaleProductConfiguration : IEntityTypeConfiguration<SaleProduct>
    {
        public void Configure(EntityTypeBuilder<SaleProduct> builder)
        {
            builder.ToTable("SaleProduct");
            builder.HasKey(i => i.ShoppingCartId);
            builder.Property(i => i.ShoppingCartId).ValueGeneratedOnAdd();
            builder.Property(i => i.ShoppingCartId)
                   .IsRequired(true);
            builder.Property(s => s.Sale)
                   .IsRequired(true);
            builder.Property(p => p.Product)
                   .IsRequired(true);
            builder.Property(q => q.Quantity)
                   .IsRequired(true);
            builder.Property(p => p.Price)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 2)");
            builder.Property(d => d.Discount)
                   .IsRequired(false)
                   .HasDefaultValue(0);

            builder.HasOne<Product>(p => p.ProductObject)
                .WithMany(sp => sp.SaleProductObjects)
                .HasForeignKey(pfk => pfk.Product)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Sale>(s => s.SaleObject)
                .WithMany(sp => sp.SaleProducts)
                .HasForeignKey(sfk => sfk.Sale)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
