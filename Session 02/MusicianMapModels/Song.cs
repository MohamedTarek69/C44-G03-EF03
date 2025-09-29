using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    internal class Song
    {
        [Key]
        public string Tittle { get; set; } = null!;
        public string Author { get; set; } = null!;
        ///////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Album_Song.Song))]
        public Album_Song AlbumSongs { get; set; } = null!;
        ///////////////////////////////////////////////////////////////////////////////////////
        [InverseProperty(nameof(Mus_Song.Song))]
        public ICollection<Mus_Song> MusSongs { get; set; } = new HashSet<Mus_Song>();
        ///////////////////////////////////////////////////////////////////////////////////////
    }
}
