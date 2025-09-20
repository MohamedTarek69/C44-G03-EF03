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

    [Table("Course_Instructor")]
    [PrimaryKey(nameof(inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
            [ForeignKey(nameof(Instructors))]
            public int inst_ID { get; set; }
            [ForeignKey(nameof(Courses))]
        public int Course_ID { get; set; }

            [Range(1, 10, ErrorMessage = "Evaluate must be between 1 and 10")]
            [Column(TypeName = "int")]
            public int evaluate { get; set; }
            ///////////////////////////////////////////////////////////////////
            [InverseProperty(nameof(Instructor.InstructorsCourses))]
            public virtual Instructor Instructors { get; set; } = null!;
            [InverseProperty(nameof(Course.CourseInstructors))]
            public virtual Course Courses { get; set; } = null!;


    }
}
