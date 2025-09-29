using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.MusicianMapModels
{
    [PrimaryKey(nameof(Song_Title))]
    internal class Album_Song
    {
        [ForeignKey(nameof(Album))]
        public int Album_Id { get; set; }
        [InverseProperty(nameof(Album.AlbumSongs))]
        public Album Album { get; set; } = null!;
        ///////////////////////////////////////////////////
        [ForeignKey(nameof(Song))]
        public string Song_Title { get; set; } = null!;
        [InverseProperty(nameof(Song.AlbumSongs))]
        public Song Song { get; set; } = null!;
        ///////////////////////////////////////////////////
    }
}
