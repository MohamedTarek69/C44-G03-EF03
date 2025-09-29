using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Session_02.AirlineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesModels
{
    internal class SalesOffice
    {
        public int Number { get; set; }
        public string Location { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////
        public int Emp_Id { get; set; }
        public virtual Employee Manager { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<Property> Properties { get; set; } = new HashSet<Property>();
        /////////////////////////////////////////////////////////////////////////////////////////////
    }
}
