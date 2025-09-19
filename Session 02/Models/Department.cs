using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateOnly DateOfCreation { get; set; }
        public int Serial { get; set; }

        //[ForeignKey(nameof(Manager))]
        //public int DeptManagerId { get; set; }
        ////public int ManagerDeptId { get; set; }
        ////public int EmployeeId { get; set; }
        ////public int EmployeeDeptId { get; set; }

        //// Navigational Property [one]
        //// EF Core : Department Must Has one Employee To Manage it [Total Participation]
        //public Emploee Manager { get; set; } = null!;

    }
}
