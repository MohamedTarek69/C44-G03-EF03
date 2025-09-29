using Microsoft.EntityFrameworkCore;
using Session_02.AirlineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Contexts
{
    internal class AirlineDBContext : DbContext
    {
        public AirlineDBContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = AirlineDB;Trusted_Connection = True;TrustServerCertificate= true");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Airline_Phone>(entity =>
            {
                entity.HasKey(ap => new { ap.AL_Id, ap.Phone });

                entity.HasOne(ap => ap.Airline)
                      .WithMany(a => a.Phones)
                      .HasForeignKey(ap => ap.AL_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Emp_Qualification>(entity =>
            {
                entity.HasKey(eq => new { eq.Emp_Id, eq.Qualification });

                entity.HasOne(eq => eq.Employee)
                      .WithMany(e => e.Qualifications)
                      .HasForeignKey(eq => eq.Emp_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Aircraft_Route>(entity =>
            {
                entity.HasKey(ar => new { ar.AC_Id, ar.Route_Id });

                entity.HasOne(ar => ar.Aircraft)
                      .WithMany(ac => ac.AircraftRoutes)
                      .HasForeignKey(ar => ar.AC_Id)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(ar => ar.Route)
                      .WithMany(r => r.AircraftRoutes)
                      .HasForeignKey(ar => ar.Route_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasOne(t => t.Airline)
                      .WithMany(a => a.Transactions)
                      .HasForeignKey(t => t.AL_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(e => e.Airline)
                      .WithMany(a => a.Employees)
                      .HasForeignKey(e => e.AL_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Aircraft>(entity =>
            {
                entity.HasOne(ac => ac.Airline)
                      .WithMany(a => a.Aircrafts)
                      .HasForeignKey(ac => ac.AL_Id)
                      .OnDelete(DeleteBehavior.NoAction);
            });
        }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airline_Phone> AirlinePhones { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Emp_Qualification> EmpQualifications { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Aircraft_Route> AircraftRoutes { get; set; }

    }
}
