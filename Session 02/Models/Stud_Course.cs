using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    [Table("Student_Course")]
    [PrimaryKey(nameof(CrsId), nameof(StdId))]
    internal class Stud_Course
    {
        [ForeignKey(nameof(Course))]
        public int CrsId { get; set; }
        [ForeignKey(nameof(Student))]
        public int StdId { get; set; }
        public int Grade { get; set; }
        /////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Student.StudentsCourses))]
        public Student Student { get; set; } = null!;
        [InverseProperty(nameof(Course.CourseStudents))]
        public Course Course { get; set; } = null!;

    }
}
