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
    [PrimaryKey(nameof(Code), nameof(Brand))]
    internal class Drug_Brand
    {
        [ForeignKey(nameof(Drug))]
        public int Code { get; set; }
        public string Brand { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Drugs.DrugBrands))]
        public virtual Drugs Drug { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////
    }
}
