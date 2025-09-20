using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    internal class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }

        [Column("InstructorName", TypeName = "varchar")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Of Instructor Must Be Between 3 and 50 Char")]
        public string Name { get; set; }
        [Column("EmployeeSalary", TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        [Required]
        public string Address { get; set; }
        [Column("HourRateBouns", TypeName = "decimal(10,2)")]
        public decimal HourRateBouns { get; set; }
        ////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Dept_ID))]
        public int Dept_ID { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public Department InstructorDepartment { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Department.InstructorManageDept))]
        public Department ManagedDepartment { get; set; } = null!;
        //////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Course_Inst.Instructors))]
        public ICollection<Course_Inst> InstructorsCourses { get; set; } = new HashSet<Course_Inst>();

    }
}
