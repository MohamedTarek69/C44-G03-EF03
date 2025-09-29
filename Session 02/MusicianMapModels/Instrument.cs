using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    internal class Instrument
    {
        [Key]
        public string Name { get; set; } = null!;
        public string Key { get; set; } = null!; 
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Mus_Instrument.Instrument))]
        public ICollection<Mus_Instrument> MusInstruments { get; set; } = new HashSet<Mus_Instrument>();
        ////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

