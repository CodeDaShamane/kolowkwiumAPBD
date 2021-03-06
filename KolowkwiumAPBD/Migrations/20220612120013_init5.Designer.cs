// <auto-generated />
using System;
using KolowkwiumAPBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KolowkwiumAPBD.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20220612120013_init5")]
    partial class init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KolowkwiumAPBD.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            AlbumName = "Album name 1",
                            PublishDate = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdAlbum = 2,
                            AlbumName = "Album name 1",
                            PublishDate = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdAlbum = 3,
                            AlbumName = "Album name 1",
                            PublishDate = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.MusicLabel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumIdAlbum")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.HasIndex("AlbumIdAlbum");

                    b.ToTable("MusicLabels");

                    b.HasData(
                        new
                        {
                            IdMusicLabel = 1,
                            Name = "BOR"
                        },
                        new
                        {
                            IdMusicLabel = 2,
                            Name = "WWO"
                        },
                        new
                        {
                            IdMusicLabel = 3,
                            Name = "Prosto"
                        });
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.Musician", b =>
                {
                    b.Property<int>("IdMusician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusician");

                    b.ToTable("Musicians");

                    b.HasData(
                        new
                        {
                            IdMusician = 1,
                            FirstName = "Albert",
                            LastName = "Mata",
                            NickName = "Bercik"
                        },
                        new
                        {
                            IdMusician = 2,
                            FirstName = "Norbert",
                            LastName = "Maliszewski",
                            NickName = "Włodek"
                        },
                        new
                        {
                            IdMusician = 3,
                            FirstName = "Torbert",
                            LastName = "Kowalski",
                            NickName = "Burak"
                        });
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumNavIdAlbum")
                        .HasColumnType("int");

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTrack");

                    b.HasIndex("AlbumNavIdAlbum");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            Duration = 15.6f,
                            TrackName = "AlbertaTrack"
                        },
                        new
                        {
                            IdTrack = 2,
                            Duration = 25.1f,
                            TrackName = "NorbertaTrack"
                        },
                        new
                        {
                            IdTrack = 3,
                            Duration = 35.2f,
                            TrackName = "TorbertaTrack"
                        });
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.MusicLabel", b =>
                {
                    b.HasOne("KolowkwiumAPBD.Models.Album", null)
                        .WithMany("MusicLabels")
                        .HasForeignKey("AlbumIdAlbum");
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.Track", b =>
                {
                    b.HasOne("KolowkwiumAPBD.Models.Album", "AlbumNav")
                        .WithMany()
                        .HasForeignKey("AlbumNavIdAlbum");

                    b.Navigation("AlbumNav");
                });

            modelBuilder.Entity("KolowkwiumAPBD.Models.Album", b =>
                {
                    b.Navigation("MusicLabels");
                });
#pragma warning restore 612, 618
        }
    }
}
