using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    [PrimaryKey(nameof(Emp_Id), nameof(Qualification))]
    internal class Emp_Qualification
    {
        public string Qualification { get; set; } = null!;
        ////////////////////////////////////////////////////////
        [ForeignKey(nameof(Employee))]
        public int Emp_Id { get; set; }
        [InverseProperty(nameof(Employee.Qualifications))]
        public Employee Employee { get; set; } = null!;
        ////////////////////////////////////////////////////////

    }
}
