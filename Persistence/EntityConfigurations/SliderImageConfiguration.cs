using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class SliderImageConfiguration : BaseEntityTypeConfiguration<SliderImage, Guid>
{
    public override void Configure(EntityTypeBuilder<SliderImage> builder)
    {
        builder.ToTable("SliderImages");

        builder.Property(b => b.SliderId).HasColumnName("SliderId");
        builder.Property(b => b.ImagePath).HasColumnName("ImagePath").HasMaxLength(1000);
        builder.Property(b => b.Order).HasColumnName("Order").HasDefaultValue(1);

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        base.Configure(builder);
    }
}