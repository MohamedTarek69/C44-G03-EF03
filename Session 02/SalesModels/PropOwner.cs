using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.SalesModels
{
    internal class PropOwner
    {
        public int Own_Id { get; set; }
        public int Prop_Id { get; set; }
        public double Precent { get; set; } 
        ///////////////////////////////////////////////////
        public virtual Owner Owner { get; set; }
        ///////////////////////////////////////////////////
        public virtual Property Property { get; set; }
        ///////////////////////////////////////////////////
    }
}
