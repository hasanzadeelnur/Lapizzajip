using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class ServiceConfiguration : BaseEntityTypeConfiguration<Service, Guid>
{
    public override void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");

        builder.Property(b => b.Title).HasColumnName("Title").HasMaxLength(100);
        builder.Property(b => b.Subtitle).HasColumnName("Subtitle").HasMaxLength(100);
        builder.Property(b => b.ImagePath).HasColumnName("ImagePath").HasMaxLength(300);
        builder.Property(b => b.Order).HasColumnName("Order").HasDefaultValue(1);
        builder.Property(b => b.Status).HasColumnName("Status");

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        base.Configure(builder);
    }
}