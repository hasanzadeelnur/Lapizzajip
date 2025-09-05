using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;
internal class ProductConfiguration : BaseEntityTypeConfiguration<Product, Guid>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(c => c.Id);

        builder.Property(c => c.CategoryId).HasColumnName("CategoryId");
        builder.Property(c => c.ImagePath).HasColumnName("ImagePath").HasMaxLength(1000);
        builder.Property(c => c.SpecialImagePath).HasColumnName("SpecialImagePath").HasMaxLength(1000);
        builder.Property(c => c.Price).HasColumnName("Price");
        builder.Property(c => c.Order).HasColumnName("Order");
        builder.Property(c => c.SpecialOrder).HasColumnName("SpecialOrder");
        builder.Property(c => c.Status).HasColumnName("Status");

        builder.HasOne(c => c.Category).WithMany(c => c.Products).HasForeignKey(c => c.CategoryId);

        builder.Navigation(c => c.Translations).AutoInclude();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        base.Configure(builder);
    }
}