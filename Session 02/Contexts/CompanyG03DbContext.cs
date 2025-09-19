using Microsoft.EntityFrameworkCore;
using Session_02.Configrations;
using Session_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Contexts
{
    internal class CompanyG03DbContext : DbContext
    {
        public CompanyG03DbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfigrations());
            //modelBuilder.ApplyConfiguration(new DepartmentConfigrations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Emploee>()
                        .HasOne(E => E.ManagedDepartment)
                        .WithOne(D => D.Manager)
                        .HasForeignKey<Department>(D => D.DeptManagerId)
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired(true);

            //modelBuilder.Entity<Department>()
            //            .HasOne(D => D.Manager)
            //            .WithOne(E => E.ManagedDepartment)
            //            .HasForeignKey<Department>(D => D.DeptManagerId);

            //modelBuilder.Entity<Emploee>()
            //            .HasOne<Department>()
            //            .WithOne()
            //            .HasForeignKey<Department>(D => D.DeptManagerId);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = DESKTOP-JF6NGA5;Initial Catalog = CompanyDB1;Integraded Security = true");
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = CompanyG03DB;Trusted_Connection = True;TrustServerCertificate= true");
        }

        //public DbSet<Emploee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

    }
}
