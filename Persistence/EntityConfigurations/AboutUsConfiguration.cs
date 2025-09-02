using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class AboutUsConfiguration : BaseEntityTypeConfiguration<AboutUs, Guid>
{
    public override void Configure(EntityTypeBuilder<AboutUs> builder)
    {
        builder.ToTable("AboutUs");

        builder.Property(a => a.FirstImagePath).HasColumnName("FirstImagePath").HasMaxLength(1000);
        builder.Property(a => a.FirstBody).HasColumnName("FirstBody").HasMaxLength(3000);
        builder.Property(a => a.SecondImagePath).HasColumnName("SecondImagePath").HasMaxLength(1000);
        builder.Property(a => a.SecondBody).HasColumnName("SecondBody").HasMaxLength(3000);
        builder.Property(a => a.StoryBody).HasColumnName("StoryBody").HasMaxLength(3000);
        builder.Property(bc => bc.MetaTitle).HasColumnName("MetaTitle").HasMaxLength(100);
        builder.Property(bc => bc.MetaDescription).HasColumnName("MetaDescription").HasMaxLength(500);
        builder.Property(bc => bc.MetaKeys).HasColumnName("MetaKeys").HasMaxLength(400);
        builder.Property(a => a.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2);

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        builder.HasData(GetSeeds());

        base.Configure(builder);
    }

    private static IEnumerable<AboutUs> GetSeeds()
    {
        List<AboutUs> aboutUsList = [
            new()
            {
                Id = Guid.Parse("b3ed0380-1c80-45e8-b39e-37a43c8ae815"),
                CreatedDate = new DateTime(2025,2,9),
                LanguageKey = "ko",
            },
            new()
            {
                Id = Guid.Parse("6192bb73-9d91-4ab6-8889-bb5665ea40fd"),
                CreatedDate = new DateTime(2025,2,9),
                LanguageKey = "az",
            },
            new()
            {
                Id = Guid.Parse("782a1df2-f4a0-4a08-88fe-47f5923f7f5b"),
                CreatedDate = new DateTime(2025,2,9),
                LanguageKey = "en",
            },
            new()
            {
                Id = Guid.Parse("3136a22e-e622-4f41-a416-cc1161483611"),
                CreatedDate =new DateTime(2025,2,9),
                LanguageKey = "ru",
            },
            new()
            {
                Id = Guid.Parse("1b0d2143-b66a-41b5-85ae-c7bdc6e8ca4f"),
                CreatedDate = new DateTime(2025,2,9),
                LanguageKey = "tr",
            }];

        return [.. aboutUsList];
    }
}