using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class modifiedCategoryURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "https://st2.depositphotos.com/1006689/10117/v/450/depositphotos_101178346-stock-illustration-laptop-computer-vector-icon.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "data:image/png;base64,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");
        }
    }
}
