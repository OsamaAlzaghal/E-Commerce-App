using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Find all PCs and Laptops in our store here!", "PC && Laptops" },
                    { 2, "Find Speakers and headsets in our store here!", "Audio Devices" },
                    { 3, "Find all Televitions in our store here!", "PC && Laptops" },
                    { 4, "Find all moblie devices in our store here!", "Mobile Phones" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Name", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "laithalamat@LTUC.com", "Laith Alamat", "12345", "0777" },
                    { 2, "osamaalzaghal@LTUC.com", "Osama Alzaghal", "12345", "0778" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Description", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A gaming laptop with great performance", true, "ASUS Laptop", 1000.0 },
                    { 2, 1, "A gaming laptop with great performance", true, "Acer Laptop", 900.0 },
                    { 3, 1, "A descktop pc with great performance", true, "iMac Retina", 1500.0 },
                    { 4, 1, "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", true, "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", 1000.0 },
                    { 5, 2, "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", true, "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", 100.0 },
                    { 6, 2, "High performance speaker system that produces 50 Watts of raw, rock solid audio power", true, "Creative SBS E2800 2.1 High Performance Speakers System - Black", 55.0 },
                    { 7, 3, "4-Series 4K UHD smart TV", true, "Amazon Fire TV 43", 250.0 },
                    { 8, 3, "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", true, "Pioneer 43-inch", 210.0 },
                    { 9, 4, "Apple Flagship mobile phone with 256GB", false, "iPhone 13 Pro Max", 1200.0 },
                    { 10, 4, "Samsung Flagship mobile phone with 256GB", true, "Samsung Galaxy S22 Ultra", 1000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
