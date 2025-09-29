using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.HospitalModels
{
    [PrimaryKey(nameof(Nur_Num), nameof(Drug_code), nameof(Pat_Id))]
    internal class Nurse_Drug_Patient
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Dosage { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Nurse))]
        public int Nur_Num { get; set; }
        [InverseProperty(nameof(Nurse.NurseDrugRecords))]
        public Nurse Nurse { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Drug))]
        public int Drug_code { get; set; }
        [InverseProperty(nameof(Drugs.NurseDrugRecords))]
        public Drugs Drug { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Patient))]
        public int Pat_Id { get; set; }
        [InverseProperty(nameof(Patient.NurseDrugPatients))]
        public Patient Patient { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////

    }
}
