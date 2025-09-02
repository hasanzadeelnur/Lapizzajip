using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class ContactUsConfiguration : BaseEntityTypeConfiguration<ContactUs, Guid>
{
    public override void Configure(EntityTypeBuilder<ContactUs> builder)
    {
        builder.ToTable("ContactUs");

        builder.Property(cu => cu.MapX).HasColumnName("MapX").HasMaxLength(500);
        builder.Property(cu => cu.MapY).HasColumnName("MapY").HasMaxLength(500);
        builder.Property(cu => cu.Phones).HasColumnName("Phone").HasMaxLength(500);
        builder.Property(cu => cu.Emails).HasColumnName("Email").HasMaxLength(500);
        builder.Property(cu => cu.TikTokAddress).HasColumnName("TikTokAddress").HasMaxLength(500);
        builder.Property(cu => cu.FacebookAddress).HasColumnName("FacebookAddress").HasMaxLength(500);
        builder.Property(cu => cu.LinkedinAddress).HasColumnName("LinkedinAddress").HasMaxLength(500);
        builder.Property(cu => cu.InstagramAddress).HasColumnName("InstagramAddress").HasMaxLength(500);
        builder.Property(cu => cu.WhatsappNumber).HasColumnName("WhatsappNumber").HasMaxLength(500);

        builder.Navigation(b => b.Translations).AutoInclude();

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        builder.HasData(GetSeeds());

        base.Configure(builder);
    }

    private static IEnumerable<ContactUs> GetSeeds()
    {
        List<ContactUs> contactUsList = [];

        ContactUs contactUs =
            new()
            {
                Id = Guid.Parse("2be6044a-deea-4b46-a7a6-4beef40db34e"),
                Emails = "noreply@carlog.com",
                FacebookAddress = "https://www.facebook.com/",
                InstagramAddress = "https://www.instagram.com/",
                LinkedinAddress = "https://linkedin.com/",
                TikTokAddress = "https://tiktok.com",
                Phones = "+99 (0) 101 0000 888",
                MapX = "40.409264",
                MapY = "49.867092",
                CreatedDate = new DateTime(2025, 2, 9),
            };
        contactUsList.Add(contactUs);

        return [.. contactUsList];
    }
}
