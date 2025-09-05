using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations.Translations;

internal class SliderTranslatioCnonfiguration : BaseEntityTypeConfiguration<SliderTranslation, Guid>
{
    public override void Configure(EntityTypeBuilder<SliderTranslation> builder)
    {
        builder.ToTable("SliderTranslations").HasKey(c => c.Id);

        builder.Property(c => c.SliderId).HasColumnName("SliderId");
        builder.Property(c => c.Title).HasColumnName("Title").HasMaxLength(500);
        builder.Property(c => c.Subtitle).HasColumnName("Subtitle").HasMaxLength(1000);
        builder.Property(c => c.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2);

        builder.HasIndex(c => new { c.SliderId, c.LanguageKey, c.DeletedDate }).HasDatabaseName("IX_SliderTranslations_SliderId_LanguageKey").IsUnique();

        builder.HasOne(c => c.Slider).WithMany(c => c.Translations).HasForeignKey(c => c.SliderId);

        builder.Navigation(c => c.Slider).AutoInclude();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        base.Configure(builder);
    }
}
