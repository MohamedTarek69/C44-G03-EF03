using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    internal class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public decimal Amout { get; set; }
        public DateTime Date { get; set; }
        ///////////////////////////////////////////////////
        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }
        [InverseProperty(nameof(Airline.Transactions))]
        public Airline Airline { get; set; } = null!;
        ///////////////////////////////////////////////////
    }
}
