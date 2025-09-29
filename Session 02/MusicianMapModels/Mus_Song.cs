using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    [PrimaryKey(nameof(Mus_Id), nameof(Song_Tittle))]
    internal class Mus_Song
    {
        [ForeignKey(nameof(Musician))]
        public int Mus_Id { get; set; }
        [InverseProperty(nameof(Musician.MusSongs))]
        public Musician Musician { get; set; } = null!;
        ///////////////////////////////////////////////////
        [ForeignKey(nameof(Song))]
        public string Song_Tittle { get; set; } = null!;
        [InverseProperty(nameof(Song.MusSongs))]
        public Song Song { get; set; } = null!;
        ///////////////////////////////////////////////////
    }
}
