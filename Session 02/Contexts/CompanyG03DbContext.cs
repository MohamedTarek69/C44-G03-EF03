using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = AssignmentEfCore02DB;Trusted_Connection = True;TrustServerCertificate= true");


        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Student_Courses { get; set; }

    }
}
