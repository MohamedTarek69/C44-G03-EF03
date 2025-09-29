using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.ITIModels
{
    internal class Course
    {
        public int Id { get; set; }

        [Range(4, 6, ErrorMessage = "Duration should be between 4 and 6 months")]
        public int Duration { get; set; }

        [Column("CourseName")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        //////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Stud_Course.Course))]
        public ICollection<Stud_Course> CourseStudents { get; set; } = new HashSet<Stud_Course>();
        ////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Topics))]
        public int Top_ID { get; set; }
        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topics { get; set; }
        ///////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Course_Inst.Courses))]
        public ICollection<Course_Inst> CourseInstructors { get; set; } = new HashSet<Course_Inst>();
    }
}
