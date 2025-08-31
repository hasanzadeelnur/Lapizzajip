using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class ProductCategoryConfiguration : BaseEntityTypeConfiguration<ProductCategory, Guid>
{
    public override void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategories").HasKey(c => c.Id);

        builder.Property(c => c.Order).HasColumnName("Order");
        builder.Property(c => c.Status).HasColumnName("Status");

        builder.Navigation(c => c.Translations).AutoInclude();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        base.Configure(builder);
    }
}
