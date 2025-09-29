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
    internal class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.PropertyOwners)
                   .WithOne(po => po.Property)
                   .HasForeignKey(po => po.Prop_Id)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
        }
    }
}
