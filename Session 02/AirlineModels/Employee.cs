using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int BD_Year { get; set; }
        public int BD_Month { get; set; }
        public int BD_Day { get; set; }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }
        [InverseProperty(nameof(Airline.Employees))]
        public Airline Airline { get; set; } = null!;
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Emp_Qualification.Employee))]
        public ICollection<Emp_Qualification> Qualifications { get; set; } = new HashSet<Emp_Qualification>();
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
