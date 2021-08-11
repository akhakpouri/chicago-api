using Chicago.Dal.Models;
using Daytona.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chicago.Dal.EntityConfiguration
{
    public class NetworthEntityConfiguration : AuditableEntityConfiguration<Networth>
    {
        public override void Configure(EntityTypeBuilder<Networth> builder)
        {
            builder.Property(n => n.CapturedDate).HasColumnType("datetime2").IsRequired();
            builder.HasIndex(a => new { a.CapturedDate }).IsUnique();
            base.Configure(builder);
        }
    }
}
