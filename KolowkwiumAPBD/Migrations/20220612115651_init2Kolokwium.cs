using Microsoft.EntityFrameworkCore.Migrations;

namespace KolowkwiumAPBD.Migrations
{
    public partial class init2Kolokwium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_IdMusicAlbum",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_IdMusicAlbum",
                table: "Tracks");

            migrationBuilder.AddColumn<int>(
                name: "IdAlbum",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdAlbum",
                table: "Tracks",
                column: "IdAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks",
                column: "IdAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_IdAlbum",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "IdAlbum",
                table: "Tracks");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdMusicAlbum",
                table: "Tracks",
                column: "IdMusicAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_IdMusicAlbum",
                table: "Tracks",
                column: "IdMusicAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
