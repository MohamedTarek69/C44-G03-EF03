using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    internal class Drugs
    {
        [Key]
        public int Code { get; set; }
        public string Dosage { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Drug_Brand.Drug))]
        public ICollection<Drug_Brand> DrugBrands { get; set; } = new HashSet<Drug_Brand>();
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Nurse_Drug_Patient.Drug))]
        public virtual ICollection<Nurse_Drug_Patient> NurseDrugRecords { get; set; } = new HashSet<Nurse_Drug_Patient>();
        ////////////////////////////////////////////////////////////////////////////////
    }
}
