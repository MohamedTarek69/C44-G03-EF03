using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    [PrimaryKey(nameof(Mus_Id), nameof(Inst_Name))]
    internal class Mus_Instrument
    {
        [ForeignKey(nameof(Musician))]
        public int Mus_Id { get; set; }
        [InverseProperty(nameof(Musician.MusInstruments))]
        public Musician Musician { get; set; } = null!;
        ////////////////////////////////////////////////////////
        [ForeignKey(nameof(Instrument))]
        public string Inst_Name { get; set; } = null!;
        [InverseProperty(nameof(Instrument.MusInstruments))]
        public Instrument Instrument { get; set; } = null!;
        ////////////////////////////////////////////////////////
    }
}
