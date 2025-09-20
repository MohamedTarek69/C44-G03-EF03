using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        // Navigational Property [Many]
        //[InverseProperty(nameof(Student.Courses))]
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(CourseStudent.Course))]
        public ICollection<CourseStudent> CourseStudents { get; set; } = new HashSet<CourseStudent>();
    }
}
