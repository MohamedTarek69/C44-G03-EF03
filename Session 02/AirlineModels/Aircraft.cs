using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    internal class Aircraft
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; } = null!;
        public string Maj_pilot { get; set; } = null!;
        public string Assistant { get; set; } = null!;
        public string Host1 { get; set; } = null!;
        public string Host2 { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }

        [InverseProperty(nameof(Airline.Aircrafts))]
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public Airline Airline { get; set; } = null!;

        [InverseProperty(nameof(Aircraft_Route.Aircraft))]
        public ICollection<Aircraft_Route> AircraftRoutes { get; set; } = new HashSet<Aircraft_Route>();
        /////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
