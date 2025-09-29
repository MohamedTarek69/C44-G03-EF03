using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    [PrimaryKey(nameof(Con_Id), nameof(Pat_Id))]
    internal class Patient_Con
    {   
        [ForeignKey(nameof(Consultant))]
        public int Con_Id { get; set; }
        [ForeignKey(nameof(Patient))]
        public int Pat_Id { get; set; }
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Consultant.Patient_Cons))]
        public virtual Consultant Consultant { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Patient.Patient_Cons))]
        public virtual Patient Patient { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
    }
}
