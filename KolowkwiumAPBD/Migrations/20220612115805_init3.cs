using Microsoft.EntityFrameworkCore.Migrations;

namespace KolowkwiumAPBD.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "IdAlbum",
                table: "Tracks",
                newName: "AlbumNavIdAlbum");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_IdAlbum",
                table: "Tracks",
                newName: "IX_Tracks_AlbumNavIdAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumNavIdAlbum",
                table: "Tracks",
                column: "AlbumNavIdAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumNavIdAlbum",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "AlbumNavIdAlbum",
                table: "Tracks",
                newName: "IdAlbum");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_AlbumNavIdAlbum",
                table: "Tracks",
                newName: "IX_Tracks_IdAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks",
                column: "IdAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
