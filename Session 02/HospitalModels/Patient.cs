using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DOB { get; set; }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Ward))]
        public int Ward_Id { get; set; }
        [InverseProperty(nameof(Ward.Patients))]
        public Ward Ward { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Consultant))]
        public int Con_Id { get; set; }
        [InverseProperty(nameof(Consultant.Patients))]
        public Consultant Consultant { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [InverseProperty(nameof(Patient_Con.Patient))]
        public ICollection<Patient_Con> Patient_Cons { get; set; } = new HashSet<Patient_Con>();
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Nurse_Drug_Patient.Patient))]
        public ICollection<Nurse_Drug_Patient> NurseDrugPatients { get; set; } = new HashSet<Nurse_Drug_Patient>();
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
