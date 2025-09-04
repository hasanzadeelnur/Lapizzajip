using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class SliderConfiguration : BaseEntityTypeConfiguration<Slider, Guid>
{
    public override void Configure(EntityTypeBuilder<Slider> builder)
    {
        builder.ToTable("Sliders");

        builder.Property(b => b.ImagePath).HasColumnName("ImagePath").HasMaxLength(1000);
        builder.Property(b => b.Order).HasColumnName("Order").HasDefaultValue(1);
        builder.Property(b => b.Status).HasColumnName("Status");

        builder.Navigation(c => c.Translations).AutoInclude();
        builder.Navigation(c => c.Images).AutoInclude();

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        base.Configure(builder);
    }
}
