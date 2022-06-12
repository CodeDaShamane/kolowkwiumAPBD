using Microsoft.EntityFrameworkCore.Migrations;

namespace KolowkwiumAPBD.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMusicAlbum",
                table: "Tracks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMusicAlbum",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
