using Session_02.ITIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    internal class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Patient.Ward))]
        public virtual ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();
        //////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Nurse.Ward))]
        public virtual ICollection<Nurse> Nurses { get; set; } = new HashSet<Nurse>();
        //////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(WardManager))]
        public int Nurse_Num { get; set; }
        [InverseProperty(nameof(Nurse.ManagedWards))]
        public virtual Nurse WardManager { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////
    }
}
