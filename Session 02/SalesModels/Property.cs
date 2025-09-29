using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesModels
{
    internal class Property
    {
        public int Id { get; set; }
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Code { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public int Off_Number { get; set; }
        public virtual SalesOffice SalesOffice { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<PropOwner> PropertyOwners { get; set; } = new HashSet<PropOwner>();
        /////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
