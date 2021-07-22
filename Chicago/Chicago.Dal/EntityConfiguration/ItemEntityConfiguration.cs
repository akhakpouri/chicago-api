using Chicago.Dal.Models;
using Daytona.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Chicago.Dal.EntityConfiguration
{
    public class ItemEntityConfiguration : AuditableEntityConfiguration<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(i => i.Name).IsRequired().HasMaxLength(250);
            builder.Property(i => i.Type).IsRequired();
            builder.Property(i => i.Balance).IsRequired();
            builder.HasCheckConstraint("CK_Item_Balance", "[Balance] >= 0.0");
            base.Configure(builder);
        }
    }
}
