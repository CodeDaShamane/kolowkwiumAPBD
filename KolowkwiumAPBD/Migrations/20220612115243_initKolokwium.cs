using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KolowkwiumAPBD.Migrations
{
    public partial class initKolokwium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    IdAlbum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.IdAlbum);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    IdMusician = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.IdMusician);
                });

            migrationBuilder.CreateTable(
                name: "MusicLabels",
                columns: table => new
                {
                    IdMusicLabel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumIdAlbum = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicLabels", x => x.IdMusicLabel);
                    table.ForeignKey(
                        name: "FK_MusicLabels_Albums_AlbumIdAlbum",
                        column: x => x.AlbumIdAlbum,
                        principalTable: "Albums",
                        principalColumn: "IdAlbum",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    IdTrack = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusicAlbum = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    TrackName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.IdTrack);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_IdMusicAlbum",
                        column: x => x.IdMusicAlbum,
                        principalTable: "Albums",
                        principalColumn: "IdAlbum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "IdAlbum", "AlbumName", "PublishDate" },
                values: new object[,]
                {
                    { 1, "Album name 1", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Album name 1", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Album name 1", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MusicLabels",
                columns: new[] { "IdMusicLabel", "AlbumIdAlbum", "Name" },
                values: new object[,]
                {
                    { 1, null, "BOR" },
                    { 2, null, "WWO" },
                    { 3, null, "Prosto" }
                });

            migrationBuilder.InsertData(
                table: "Musicians",
                columns: new[] { "IdMusician", "FirstName", "LastName", "NickName" },
                values: new object[,]
                {
                    { 1, "Albert", "Mata", "Bercik" },
                    { 2, "Norbert", "Maliszewski", "Włodek" },
                    { 3, "Torbert", "Kowalski", "Burak" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[,]
                {
                    { 1, 15.6f, 0, "AlbertaTrack" },
                    { 2, 25.1f, 0, "NorbertaTrack" },
                    { 3, 35.2f, 0, "TorbertaTrack" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicLabels_AlbumIdAlbum",
                table: "MusicLabels",
                column: "AlbumIdAlbum");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdMusicAlbum",
                table: "Tracks",
                column: "IdMusicAlbum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicians");

            migrationBuilder.DropTable(
                name: "MusicLabels");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
