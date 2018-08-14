using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Data
{
    public class CustomerConfig : IEntityTypeConfiguration<Domain.Customer>
    {
        public void Configure(EntityTypeBuilder<Domain.Customer> builder)
        {
            builder.ToTable(nameof(Domain.Customer));
            builder.OwnsOne(
                o => o.Created,
                sa =>
                {
                    sa.Property(p => p.Reason).HasMaxLength(255).IsUnicode(false);
                }
            );

            builder.Property(x => x.TenantId).IsRequired();
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.HasKey(x => new { x.TenantId, x.ProviderId, x.ProviderKey });
            builder.Property(x => x.ProviderKey).HasMaxLength(50).IsUnicode(false);

            builder.Property(x => x.DisplayName).HasMaxLength(255).IsUnicode(false);
        }
    }
}
