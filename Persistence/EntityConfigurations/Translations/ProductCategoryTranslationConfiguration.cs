using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations.Translations;

internal class ProductCategoryTranslationConfiguration : BaseEntityTypeConfiguration<ProductCategoryTranslation, Guid>
{
    public override void Configure(EntityTypeBuilder<ProductCategoryTranslation> builder)
    {
        builder.ToTable("ProductCategoryTranslations").HasKey(c => c.Id);

        builder.Property(c => c.CategoryId).HasColumnName("CategoryId");
        builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(1000);
        builder.Property(c => c.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2);

        builder.HasIndex(c => new { c.CategoryId, c.LanguageKey }).HasDatabaseName("IX_ProductCategoryTranslations_CategoryId_LanguageKey").IsUnique();

        builder.HasOne(c => c.Category).WithMany(c => c.Translations).HasForeignKey(c => c.CategoryId);

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        base.Configure(builder);
    }
}