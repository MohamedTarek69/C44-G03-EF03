using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }
        [Column("FIrstName", TypeName = "varchar")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name Of Student Must Be Between 3 and 50 Char")]
        public string FName { get; set; }
        [Column("LastName", TypeName = "varchar")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name Of Student Must Be Between 3 and 50 Char")]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(18, 60)]
        public int Age { get; set; }
        /////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(StudentDepartment))]
        public int Dep_Id { get; set; }
        [InverseProperty(nameof(Department.Students))]
        public Department StudentDepartment { get; set; } = null!;
        ///////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Stud_Course.Student))]
        public ICollection<Stud_Course> StudentsCourses { get; set; } = new HashSet<Stud_Course>();
        ///////////////////////////////////////////////////////////////////
    }
}
