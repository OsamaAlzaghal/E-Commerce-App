using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CartID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "administrator", "00000000-0000-0000-0000-000000000000", "administrator", "ADMINISTRATOR" },
                    { "editor", "00000000-0000-0000-0000-000000000000", "editor", "EDITOR" },
                    { "user", "00000000-0000-0000-0000-000000000000", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Description", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Find all PCs and Laptops in our store here!", "PC && Laptops", "data:image/png;base64,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" },
                    { 2, "Find Speakers and headsets in our store here!", "Audio Devices", "https://i.pinimg.com/736x/48/0c/da/480cda32088d4e5a1c0e4f53a2bb0fbc.jpg" },
                    { 3, "Find all Televitions in our store here!", "Televitions and Monitors", "https://i.pinimg.com/736x/5b/6c/d7/5b6cd7388dc2e7825191cfbd31e25c1d.jpg" },
                    { 4, "Find all moblie devices in our store here!", "Mobile Phones", "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/cell-phone-design-template-608242c6014c909324ec156c32889970_screen.jpg?ts=1581061060" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "permissions", "create", "administrator" },
                    { 2, "permissions", "delete", "administrator" },
                    { 3, "permissions", "create", "editor" },
                    { 4, "permissions", "update", "editor" },
                    { 5, "permissions", "create", "user" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CartID", "CategoryID", "Description", "InStock", "Name", "Price", "URL" },
                values: new object[,]
                {
                    { 1, null, 1, "A gaming laptop with great performance", true, "ASUS Laptop", 1000.0, "" },
                    { 2, null, 1, "A gaming laptop with great performance", true, "Acer Laptop", 900.0, "" },
                    { 3, null, 1, "A descktop pc with great performance", true, "iMac Retina", 1500.0, "" },
                    { 4, null, 1, "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", true, "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", 1000.0, "" },
                    { 5, null, 2, "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", true, "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", 100.0, "" },
                    { 6, null, 2, "High performance speaker system that produces 50 Watts of raw, rock solid audio power", true, "Creative SBS E2800 2.1 High Performance Speakers System - Black", 55.0, "" },
                    { 7, null, 3, "4-Series 4K UHD smart TV", true, "Amazon Fire TV 43", 250.0, "" },
                    { 8, null, 3, "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", true, "Pioneer 43-inch", 210.0, "" },
                    { 9, null, 4, "Apple Flagship mobile phone with 256GB", false, "iPhone 13 Pro Max", 1200.0, "" },
                    { 10, null, 4, "Samsung Flagship mobile phone with 256GB", true, "Samsung Galaxy S22 Ultra", 1000.0, "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartID",
                table: "AspNetUsers",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartID",
                table: "Products",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
