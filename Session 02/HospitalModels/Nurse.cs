using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    internal class Nurse
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Ward))]
        public int Ward_Id { get; set; }
        [InverseProperty(nameof(Ward.Nurses))]
        public virtual Ward Ward { get; set; } = null!;
        //////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Ward.WardManager))]
        public virtual ICollection<Ward> ManagedWards { get; set; } = new HashSet<Ward>();
        //////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<Nurse_Drug_Patient> NurseDrugRecords { get; set; } = new HashSet<Nurse_Drug_Patient>();
    }
}
