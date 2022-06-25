using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class UpdateAudioURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "https://i.pinimg.com/736x/48/0c/da/480cda32088d4e5a1c0e4f53a2bb0fbc.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "https://w7.pngwing.com/pngs/368/623/png-transparent-symbol-computer-icons-audio-signal-loudspeaker-encapsulated-postscript-loudspeaker-miscellaneous-text-logo.png");
        }
    }
}
