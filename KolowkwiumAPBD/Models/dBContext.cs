using Microsoft.EntityFrameworkCore;
using System;
namespace KolowkwiumAPBD.Models
{
    public class dbContext : DbContext
    {
        public dbContext() { }
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost,1433; Database=CodeFirst; User Id = ShamanBase; Password = password");
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Album>(a =>
            {
                a.HasKey(a => a.IdAlbum);
                a.Property(a => a.AlbumName).IsRequired().HasMaxLength(30);
                a.Property(a => a.PublishDate).IsRequired();
                a.HasData(
                    new Album { IdAlbum = 1, AlbumName = "Album name 1", PublishDate = DateTime.Parse("2000-02-02") },
                    new Album { IdAlbum = 2, AlbumName = "Album name 1", PublishDate = DateTime.Parse("2000-02-02") },
                    new Album { IdAlbum = 3, AlbumName = "Album name 1", PublishDate = DateTime.Parse("2000-02-02") }
                    );
            });  
            modelbuilder.Entity<Musician>(m =>
            {
                m.HasKey(m => m.IdMusician);
                m.Property(m => m.FirstName).IsRequired().HasMaxLength(30);
                m.Property(m => m.LastName).IsRequired().HasMaxLength(50);
                m.Property(m => m.NickName).IsRequired().HasMaxLength(20);
                
                m.HasData(
                    new Musician { IdMusician= 1, FirstName = "Albert", LastName ="Mata", NickName="Bercik"},
                    new Musician { IdMusician = 2, FirstName = "Norbert", LastName = "Maliszewski", NickName = "Włodek" },
                    new Musician { IdMusician = 3, FirstName = "Torbert", LastName = "Kowalski", NickName = "Burak" }
                    );
            });   
            modelbuilder.Entity<Track>(t =>
            {
                t.HasKey(t => t.IdTrack);
                t.Property(t => t.TrackName).IsRequired().HasMaxLength(20);
                t.Property(t => t.Duration).IsRequired();
                //t.HasOne(t => t.AlbumNav).WithMany(e => e.TrackNav).HasForeignKey(e => e.IdAlbum);

                t.HasData(
                    new Track { IdTrack= 1, TrackName = "AlbertaTrack", Duration = 15.6f, },
                    new Track { IdTrack = 2, TrackName = "NorbertaTrack", Duration = 25.1f, },
                    new Track { IdTrack = 3, TrackName = "TorbertaTrack", Duration = 35.2f, }
                    );
            });
            modelbuilder.Entity<MusicLabel>(ml =>
            {
                ml.HasKey(ml => ml.IdMusicLabel);
                ml.Property(ml => ml.Name).IsRequired().HasMaxLength(50);
                
                ml.HasData(
                    new MusicLabel { IdMusicLabel = 1, Name = "BOR" },
                    new MusicLabel { IdMusicLabel = 2, Name = "WWO" },
                    new MusicLabel { IdMusicLabel = 3, Name = "Prosto"}
                    );
            });

        }
    }
}