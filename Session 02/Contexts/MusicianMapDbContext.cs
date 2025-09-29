using Microsoft.EntityFrameworkCore;
using Session_02.MusicianMapModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.Contexts
{
    internal class MusicianMapDbContext : DbContext
    {
        public MusicianMapDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JF6NGA5;Database = MusicianMapDb;Trusted_Connection = True;TrustServerCertificate= true");


        }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album_Song> AlbumSongs { get; set; }
        public DbSet<Mus_Song> MusSongs { get; set; }
        public DbSet<Mus_Instrument> MusInstruments { get; set; }
    }
}
