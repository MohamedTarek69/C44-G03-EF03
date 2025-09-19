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
    //By Data Annotation
    //[Table("Hamada")]
    internal class Emploee
    {
        //[Key]
        public int EmpId { get; set; }
        [Required]
        [Column("EmployeeName", TypeName = "varchar")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Name Of Employee Must Be Between 3 and 50 Char")]
        
        public string EmpName { get; set; }
        [Column("EmployeeSalary", TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        [Range(18,60)]
        [AllowedValues(25, 30, 22, 50, 60)]
        [DeniedValues(25, 30, 22, 50, 60)]
        public int Age { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public required string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //// Navigational Property [one]
        //// EF Core : Employee May Manage one Department [Partial Participation]
        //public Department? ManagedDepartment { get; set; }
    }

}
