using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    internal class Musician
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Name Of Musician Must Be Between 3 and 80 Char")]
        public string Name { get; set; } = null!;
        [DataType(DataType.PhoneNumber)]
        public string Ph_Number { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Album.Musician))]
        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Mus_Song.Musician))]
        public ICollection<Mus_Song> MusSongs { get; set; } = new HashSet<Mus_Song>();
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Mus_Instrument.Musician))]
        public ICollection<Mus_Instrument> MusInstruments { get; set; } = new HashSet<Mus_Instrument>();
        ///////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
