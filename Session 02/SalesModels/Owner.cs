using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesModels
{
    internal class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<PropOwner> PropertyOwners { get; set; } = new HashSet<PropOwner>();
        ////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
