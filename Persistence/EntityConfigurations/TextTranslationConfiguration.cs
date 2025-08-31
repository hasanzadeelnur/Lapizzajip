using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class TextTranslationConfiguration : BaseEntityTypeConfiguration<TextTranslation, int>
{
    public override void Configure(EntityTypeBuilder<TextTranslation> builder)
    {
        builder.ToTable("TextTranslations").HasKey(c => c.Id);

        builder.Property(c => c.Key).HasColumnName("Key").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Value).HasColumnName("Value").HasMaxLength(5000).IsRequired();
        builder.Property(c => c.Type).HasColumnName("Type").IsRequired();
        builder.Property(c => c.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2).IsRequired();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        //builder.HasData(GetSeeds());
    }

    private static IEnumerable<TextTranslation> GetSeeds()
    {
        List<TextTranslation> textTranslations = [];
        //int id = 0;

        return [.. textTranslations];
    }
}

