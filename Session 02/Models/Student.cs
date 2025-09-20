using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        // Navigational Property [Many]
        //[InverseProperty(nameof(Course.Students))]
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        [InverseProperty(nameof(CourseStudent.Student))]
        public ICollection<CourseStudent> StudentsCourses { get; set; } = new HashSet<CourseStudent>();
    }
}
