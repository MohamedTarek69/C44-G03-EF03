using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.AirlineModels
{
    [PrimaryKey(nameof(AL_Id), nameof(Phone))]
    internal class Airline_Phone
    {
        public string Phone { get; set; } = null!;
        //////////////////////////////////////////////////////
        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }

        [InverseProperty(nameof(Airline.Phones))]
        public Airline Airline { get; set; } = null!;
        //////////////////////////////////////////////////////
    }
}
