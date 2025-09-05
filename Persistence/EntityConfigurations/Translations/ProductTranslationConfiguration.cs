using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations.Translations;

internal class ProductTranslationConfiguration : BaseEntityTypeConfiguration<ProductTranslation, Guid>
{
    public override void Configure(EntityTypeBuilder<ProductTranslation> builder)
    {
        builder.ToTable("ProductTranslations").HasKey(c => c.Id);

        builder.Property(c => c.ProductId).HasColumnName("ProductId");
        builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(1000);
        builder.Property(c => c.ShortDescription).HasColumnName("ShortDescription").HasMaxLength(1000);
        builder.Property(c => c.Description).HasColumnName("Description").HasMaxLength(5000);
        builder.Property(c => c.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2);

        builder.HasIndex(c => new { c.ProductId, c.LanguageKey, c.DeletedDate }).HasDatabaseName("IX_ProductTranslations_ProductId_LanguageKey").IsUnique();

        builder.HasOne(c => c.Product).WithMany(c => c.Translations).HasForeignKey(c => c.ProductId);

        builder.Navigation(c => c.Product).AutoInclude();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        base.Configure(builder);
    }
}