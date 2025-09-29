using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.ITIModels
{
    internal class Topic
    {
        public int Id { get; set; }
        [Column("TopicName", TypeName = "varchar")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Of Topic Must Be Between 3 and 50 Char")]
        public string? Name { get; set; }
        /////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Course.Topics))]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
