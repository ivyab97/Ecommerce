using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfiguration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(i => i.SaleId);
            builder.Property(i => i.SaleId).ValueGeneratedOnAdd();
            builder.Property(i => i.SaleId)
                   .IsRequired(true);
            builder.Property(un => un.TotalPay)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 4)")
                   .HasDefaultValue(0);
            builder.Property(un => un.Subtotal)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 4)")
                   .HasDefaultValue(0);
            builder.Property(un => un.TotalDiscount)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 4)")
                   .HasDefaultValue(0);
            builder.Property(un => un.Taxes)
                   .IsRequired(true)
                   .HasColumnType("decimal(18, 2)")
                   .HasDefaultValue(1.21);
            builder.Property(un => un.Date)
                   .IsRequired(true)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.HasMany<SaleProduct>(sp => sp.SaleProducts)
                   .WithOne(s => s.SaleObject)
                   .HasForeignKey(sfk => sfk.Sale)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
