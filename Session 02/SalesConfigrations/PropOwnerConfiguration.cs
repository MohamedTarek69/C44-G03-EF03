using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_02.SalesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesConfigrations
{
    internal class PropOwnerConfiguration : IEntityTypeConfiguration<PropOwner>
    {
        public void Configure(EntityTypeBuilder<PropOwner> builder)
        {
            builder.HasKey(po => new { po.Own_Id, po.Prop_Id });

            builder.HasOne(po => po.Owner)
                   .WithMany(o => o.PropertyOwners)
                   .HasForeignKey(po => po.Own_Id)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
        }
    }
}
