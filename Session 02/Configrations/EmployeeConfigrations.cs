using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Configrations
{
    internal class EmployeeConfigrations : IEntityTypeConfiguration<Emploee>
    {
        public void Configure(EntityTypeBuilder<Emploee> modelBuilder)
        {
            modelBuilder.HasKey(E => E.EmpId);

            modelBuilder.Property<string>("Name");

            //modelBuilder.Entity<Emploee>().Property("EmpName");

            //modelBuilder.Entity<Emploee>().Property(nameof(Emploee.EmpName));

            modelBuilder.Property(E => E.EmpName)
                        .HasColumnName("EmployeeName")
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .IsRequired(false);
        }
    }
}
