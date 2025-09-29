using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    internal class Route
    {
        [Key]
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Destination { get; set; } = null!;
        public string Origin { get; set; } = null!;
        public string Classification { get; set; } = null!;
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Aircraft_Route.Route))]
        public ICollection<Aircraft_Route> AircraftRoutes { get; set; } = new HashSet<Aircraft_Route>();
        /////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
