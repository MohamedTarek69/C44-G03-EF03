using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    internal class Airline
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Cont_person { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Aircraft.Airline))]
        public ICollection<Aircraft> Aircrafts { get; set; } = new HashSet<Aircraft>();
        /////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Airline_Phone.Airline))]
        public ICollection<Airline_Phone> Phones { get; set; } = new HashSet<Airline_Phone>();
        /////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Transaction.Airline))]
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
        /////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Employee.Airline))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        /////////////////////////////////////////////////////////////////////////////////////
    }
}
