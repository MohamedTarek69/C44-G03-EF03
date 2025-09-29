using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
[PrimaryKey(nameof(AC_Id), nameof(Route_Id),nameof(Departure))]
    internal class Aircraft_Route
    {
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }
        ////////////////////////////////////////////////////////
        [ForeignKey(nameof(Aircraft))]
        public int AC_Id { get; set; }
        [InverseProperty(nameof(Aircraft.AircraftRoutes))]
        public Aircraft Aircraft { get; set; } = null!;
        ////////////////////////////////////////////////////////
        [ForeignKey(nameof(Route))]
        public int Route_Id { get; set; }
        [InverseProperty(nameof(Route.AircraftRoutes))]
        public Route Route { get; set; } = null!;
        ////////////////////////////////////////////////////////
    }
}
