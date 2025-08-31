using Core.Persistence.Repositories;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class SettingConfiguration : BaseEntityTypeConfiguration<Setting, Guid>
{
    public override void Configure(EntityTypeBuilder<Setting> builder)
    {
        builder.ToTable("Settings").HasKey(c=>c.Id);

        builder.Property(c => c.Key).HasColumnName("Key").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Value).HasColumnName("Value").HasMaxLength(1000).IsRequired();
        builder.Property(c => c.Comment).HasColumnName("Comment").HasMaxLength(500);
        builder.Property(c => c.Type).HasColumnName("Type").IsRequired();

        builder.HasIndex(c => c.Key).HasDatabaseName("IX_Settings_Key").IsUnique();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        builder.HasData(GetSeeds());

        base.Configure(builder);
    }

    private static IEnumerable<Setting> GetSeeds()
    {
        List<Setting> settings = [
            new(Guid.Parse("632a5639-59c9-4922-a8ec-145b6d23631d"), "header_logo", "header_logo", SettingType.File, ""),
            new(Guid.Parse("490ed2ac-ddaf-4cc3-9d63-17d3522f4823"), "header_logo_width", "100", SettingType.Number, ""),
            new(Guid.Parse("8a8bfa84-2c93-4055-a4c5-00ac6b35aec2"), "header_logo_height", "100", SettingType.Number, ""),
            new(Guid.Parse("bababe10-ee71-44a1-ada3-f41253b1f316"), "footer_logo", "footer_logo", SettingType.File, ""),
            new(Guid.Parse("6414c07a-5c40-4dc6-bdfa-3f32e5e97812"), "footer_logo_width", "100", SettingType.Number, ""),
            new(Guid.Parse("c4dc12b4-50a0-4fc6-bd5c-d33216149c23"), "footer_logo_height", "100", SettingType.Number, ""),
            new(Guid.Parse("575911e7-7965-4aaf-9731-2d1289b81158"), "favicon_logo", "favicon_logo", SettingType.File, ""),
            new(Guid.Parse("ae7654ac-63ca-432d-908d-5c738f2b5ddd"), "main_color", "#03A297", SettingType.Text, ""),
            new(Guid.Parse("f194dffe-82fa-42e3-8528-ebeced4d48cd"), "secondary_color", "#023350", SettingType.Text, ""),
            new(Guid.Parse("b76612b2-d3f8-4bb2-a3f6-996be9fdd628"), "third_color", "#ffffff", SettingType.Text, "")
            ];
        return [.. settings];
    }
}