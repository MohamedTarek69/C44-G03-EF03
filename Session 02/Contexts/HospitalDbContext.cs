using Microsoft.EntityFrameworkCore;
using Session_02.HospitalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Contexts
{
    internal class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = HospitalDbContext;Trusted_Connection = True;TrustServerCertificate= true");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient_Con>(entity =>
            {
                entity.HasKey(pc => new { pc.Con_Id, pc.Pat_Id });

                entity.HasOne(pc => pc.Patient)
                      .WithMany(p => p.Patient_Cons)
                      .HasForeignKey(pc => pc.Pat_Id)
                      .OnDelete(DeleteBehavior.NoAction); 

                entity.HasOne(pc => pc.Consultant)
                      .WithMany(c => c.Patient_Cons)
                      .HasForeignKey(pc => pc.Con_Id)
                      .OnDelete(DeleteBehavior.NoAction); 
            });
            modelBuilder.Entity<Nurse_Drug_Patient>(entity =>
            {
                entity.HasKey(ndp => new { ndp.Nur_Num, ndp.Drug_code, ndp.Pat_Id });

                entity.HasOne(ndp => ndp.Patient)
                      .WithMany(p => p.NurseDrugPatients)
                      .HasForeignKey(ndp => ndp.Pat_Id)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(ndp => ndp.Nurse)
                      .WithMany(n => n.NurseDrugRecords)
                      .HasForeignKey(ndp => ndp.Nur_Num)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(ndp => ndp.Drug)
                      .WithMany(d => d.NurseDrugRecords)
                      .HasForeignKey(ndp => ndp.Drug_code)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.HasKey(n => n.Number);

                entity.HasOne(n => n.Ward)
                      .WithMany(w => w.Nurses)
                      .HasForeignKey(n => n.Ward_Id)
                      .OnDelete(DeleteBehavior.NoAction); 
            });


        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<Drug_Brand> DrugBrands { get; set; }
        public DbSet<Patient_Con> PatientCons { get; set; }
        public DbSet<Nurse_Drug_Patient> NurseDrugPatients { get; set; }

    }
}

