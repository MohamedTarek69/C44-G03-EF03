using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    internal class Album
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = null!;
        public DateTime Date { get; set; }
        ////////////////////////////////////////////////////////////////////////////////////////
        [ForeignKey(nameof(Musician))]
        public int Mus_Id { get; set; }

        [InverseProperty(nameof(Musician.Albums))]
        public Musician Musician { get; set; } = null!;
        ////////////////////////////////////////////////////////////////////////////////////////

        [InverseProperty(nameof(Album_Song.Album))]
        public ICollection<Album_Song> AlbumSongs { get; set; } = new HashSet<Album_Song>();
        ////////////////////////////////////////////////////////////////////////////////////////
    }
}
