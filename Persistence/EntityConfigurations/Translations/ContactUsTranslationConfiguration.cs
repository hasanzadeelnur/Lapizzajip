using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations.Translations;

internal class ContactUsTranslationConfiguration : BaseEntityTypeConfiguration<ContactUsTranslation, Guid>
{
    public override void Configure(EntityTypeBuilder<ContactUsTranslation> builder)
    {
        builder.ToTable("ContactUsTranslations");

        builder.Property(bc => bc.Description).HasColumnName("Description").HasMaxLength(3000);
        builder.Property(bc => bc.WorkingHours).HasColumnName("WorkingHours").HasMaxLength(1000);
        builder.Property(bc => bc.MetaTitle).HasColumnName("MetaTitle").HasMaxLength(500);
        builder.Property(bc => bc.MetaDescription).HasColumnName("MetaDescription").HasMaxLength(500);
        builder.Property(bc => bc.MetaKeys).HasColumnName("MetaKeys").HasMaxLength(400);
        builder.Property(b => b.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2);

        builder.HasIndex(bct => new { bct.ContactUsId, bct.LanguageKey, bct.DeletedDate }).HasDatabaseName("IX_ContactUsTranslations_ContactUsId_LanguageKey").IsUnique();

        builder.HasOne(bc => bc.ContactUs).WithMany(bc => bc.Translations).HasForeignKey(bc => bc.ContactUsId);

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        base.Configure(builder);
    }
}
