using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    internal class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Patient.Consultant))]
        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Patient_Con.Consultant))]
        public ICollection<Patient_Con> Patient_Cons { get; set; } = new HashSet<Patient_Con>();


    }
}
