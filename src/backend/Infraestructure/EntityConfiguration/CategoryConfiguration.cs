using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(i => i.CategoryId);
            builder.Property(i => i.CategoryId).ValueGeneratedOnAdd();
            builder.Property(i => i.CategoryId)
                   .IsRequired(true);
            builder.Property(n => n.Name)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.HasMany<Product>(p => p.ProductObjects)
                   .WithOne(c => c.CategoryObject)
                   .HasForeignKey(cfk => cfk.Category);

            CategoryData.SeedData(builder);
        }
    }
}
