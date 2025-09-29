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
    internal class SalesOfficeConfiguration : IEntityTypeConfiguration<SalesOffice>
    {
        public void Configure(EntityTypeBuilder<SalesOffice> builder)
        {
            builder.HasKey(o => o.Number);
            builder.HasOne(o => o.Manager)
                   .WithMany(e => e.ManagedOffices) 
                   .HasForeignKey(o => o.Emp_Id)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();

            builder.HasMany(o => o.Properties) 
                   .WithOne(p => p.SalesOffice) 
                   .HasForeignKey(p => p.Off_Number)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
        }
    }
}
