using Microsoft.EntityFrameworkCore;
using Session_02.SalesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Contexts
{
    internal class SalesDbContext : DbContext
    {
        public SalesDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = SalesDB;Trusted_Connection = True;TrustServerCertificate= true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<SalesOffice> SalesOffices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PropOwner> PropOwners { get; set; }
    }
}
