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
             new(Guid.Parse("2b0a5d20-acff-4a78-a80b-ab7e0f61ba1d"), "home_cover_image", "/assets/img/hero/h1_hero.jpg", SettingType.File, ""),
            new(Guid.Parse("16324835-e330-4ab8-b85d-0c7592606af8"), "about_us_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("13b2dfc9-d575-4c65-8004-0564fc366a79"), "menu_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("d8605837-50ca-49f9-9ef7-a06f7db10ac5"), "menu_single_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("5f552a26-2170-40a0-8c86-dd2263b53d80"), "blogs_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("38650ea9-d9a1-4d99-9f1c-97dd80b2cb48"), "blog_single_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("671793b5-50b0-4641-aa38-87feade86ac1"), "contact_us_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("89128ca6-006d-4216-bf9d-48e932006ccc"), "faq_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
            new(Guid.Parse("ffcffbbe-9f1f-4bbf-bbb9-912573bdba38"), "orders_cover_image", "/assets/img/hero/about.jpg", SettingType.File, ""),
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