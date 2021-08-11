using Chicago.Dal.Models;
using Daytona.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chicago.Dal.EntityConfiguration
{
    public class NetworthItemEntityConfiguration : AuditableEntityConfiguration<NetworthItems>
    {
        public override void Configure(EntityTypeBuilder<NetworthItems> builder)
        {
            builder.HasKey(ni => new { ni.ItemId, ni.NetworthId });
            builder.HasOne(ni => ni.Item)
                .WithMany(i => i.Items)
                .HasForeignKey(ni => ni.ItemId);
            builder.HasOne(ni => ni.Networth)
                .WithMany(i => i.Items)
                .HasForeignKey(ni => ni.NetworthId);
            base.Configure(builder);
        }
    }
}
