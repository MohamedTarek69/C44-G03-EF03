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
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            
                D.ToTable("Departments", "Sales");
                D.HasKey(D => D.DeptId);

                D.Property(D => D.DeptId)
                //.ValueGeneratedNever();
                .UseIdentityColumn(10, 10);
                //.HasDefaultValue

                D.Property(D => D.DeptName)
                 .HasColumnName("DepartmentName")
                 .HasColumnType("varchar")
                 .HasMaxLength(20)
                 .IsRequired(false)
                 .HasDefaultValue("HR");

                // 15 - 9 - 2025
                D.Property(D => D.DateOfCreation)
                 .HasAnnotation("DataType", "Date")
                 //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));
                 .HasDefaultValueSql("GetDate()");
                //.HasComputedColumnSql

                D.Ignore(D => D.Serial);
        }
    }
}
