using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.ITIModels
{
    internal class Department
    {
        [Key]
        public int Dept_Id { get; set; }

        [Column("Dept_Name")]
        public string? Name { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }
        ///////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Student.StudentDepartment))]
        public ICollection<Student> Students { get; set; }
        /////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Instructor.InstructorDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        //////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(InstructorManageDept))]
        public int? Ins_ID { get; set; }
        public Instructor InstructorManageDept { get; set; } = null!;



    }
}
