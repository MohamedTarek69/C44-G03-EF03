using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesModels
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public int Off_Number { get; set; }
        public virtual SalesOffice Office { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<SalesOffice> ManagedOffices { get; set; } = new HashSet<SalesOffice>();
        ////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
