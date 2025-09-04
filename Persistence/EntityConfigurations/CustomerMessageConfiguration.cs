using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class CustomerMessageConfiguration : BaseEntityTypeConfiguration<CustomerMessage, Guid>
{
    public override void Configure(EntityTypeBuilder<CustomerMessage> builder)
    {
        builder.ToTable("CustomerMessages");

        builder.Property(cut => cut.CustomerName).HasColumnName("CustomerName").HasMaxLength(100).IsRequired();
        builder.Property(cut => cut.CustomerEmail).HasColumnName("CustomerEmail").HasMaxLength(100).IsRequired();
        builder.Property(cut => cut.CustomerPhone).HasColumnName("CustomerPhone").HasMaxLength(100).IsRequired();
        builder.Property(cut => cut.Subject).HasColumnName("Subject").HasMaxLength(500).IsRequired();
        builder.Property(cut => cut.Message).HasColumnName("Message").HasMaxLength(1000).IsRequired();

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        base.Configure(builder);
    }
}
