using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class PcSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Gaming Laptop, 17.3” 144Hz Full HD IPS-Type, Intel Core i7-11800H Processor, GeForce RTX 3050 Ti, 16GB DDR4, 512GB PCIe SSD, Gigabit Wi-Fi 6, Windows 10 Home, TUF706HEB-DB74", "ASUS TUF Gaming F17 Gaming Laptop", 1149.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Gaming Laptop, 15.6 inch QHD Display, 240Hz Refresh Rate, Intel Core i7-11800H, 16GB DDR4 RAM, 512GB SSD, NVIDIA GeForce RTX 3070 8GB GDDR6, Windows 11- Black", "Alienware M15 R6 VR Ready Gaming Laptop", 2173.98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Gaming/Creator Laptop | 12th Gen Intel i9-12900H | GeForce RTX 3080 Ti | 16inch WQXGA 240Hz G - SYNC Display | 32GB LPDDR5 | 1TB Gen 4x4 SSD | Killer Wi - Fi 6E | PT516 - 52s - 99EL", "Acer Predator Triton 500 SE Gaming/Creator Laptop", 2989.9899999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Gaming Laptop 15.6inch FHD IPS 144Hz 10th Gen Intel 6 - Core i7 - 10750H 16GB RAM 1TB PCIe SSD 6GB RTX 2060 RGB Backlit Win 10 + HDMI Cable", "Acer Predator Helios 300 Gaming Laptop", 1699.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "Gaming Laptop, Intel Core i5-10300H, NVIDIA GeForce RTX 3050, 16GB RAM, 512GB NVMe PCIe SSD, 15.6inch FHD 144Hz IPS Display, Wi-Fi 6, Backlit Keyboard, Windows 11 Home, JAWFOAL", "Acer Nitro 5 Gaming Laptop", 899.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "15.6inch Full HD IPS Display | 11th Gen Intel Core i3 - 1115G4 Processor | 4GB DDR4 | 128GB NVMe SSD | WiFi 6 | Windows 11 Home in S mode", "Acer Aspire 5 A515 - 56 - 32DK Slim Laptop", 339.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "Gaming Laptop, 17.3inch FHD 144Hz IPS Display, Intel Core i7-11800H, GeForce RTX 3060, 32GB RAM, 512GB SSD + 1TB SSD, Backlit KB, Wi-Fi 6, HDMI, Webcam, Windows 11 Home", "Lenovo Legion 5i Gaming Laptop", 1799.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "Gaming Laptop, 17.3inch Full HD Display, AMD Ryzen 5 5600H Processor, NVIDIA GeForce GTX 1650, 32GB RAM, 1TB SSD, Backlit Keyboard, Webcam, Wi-Fi 6, Windows 11 Home, Black", "Lenovo Legion 5 Gaming Laptop", 999.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Description", "InStock", "Name", "Price" },
                values: new object[] { 1, "Gaming Laptop, 17.3inch Full HD Display, AMD Ryzen 5 5600H Processor, NVIDIA GeForce GTX 1650, 32GB RAM, 2TB SSD, Backlit Keyboard, Webcam, Wi-Fi 6, Windows 11 Home, Black", true, "Lenovo Legion 5 Gaming Laptop", 1199.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Description", "Name", "Price", "URL" },
                values: new object[] { 1, "16inch 165Hz QHD IPS Gaming Laptop, AMD Ryzen 7 5800H, NVIDIA GeForce RTX 3070,RGB Backlight, TGP 130W, 32GB RAM, 2TB PCIe SSD, Windows 10H, ES 32GB USB", "Lenovo Legion 5 Pro", 1999.0, "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CartID", "CategoryID", "Description", "InStock", "Name", "Price", "URL" },
                values: new object[,]
                {
                    { 39, null, 4, "Apple Flagship mobile phone with 256GB", false, "iPhone 13 Pro Max", 1200.0, "" },
                    { 38, null, 3, "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", true, "Pioneer 43-inch", 210.0, "" },
                    { 37, null, 3, "4-Series 4K UHD smart TV", true, "Amazon Fire TV 43", 250.0, "" },
                    { 36, null, 2, "High performance speaker system that produces 50 Watts of raw, rock solid audio power", true, "Creative SBS E2800 2.1 High Performance Speakers System - Black", 55.0, "" },
                    { 35, null, 2, "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", true, "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", 100.0, "" },
                    { 34, null, 1, "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", true, "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", 1000.0, "" },
                    { 33, null, 1, "A descktop pc with great performance", true, "iMac Retina", 1500.0, "" },
                    { 32, null, 1, "AMD Radeon RX 5500, AMD Ryzen 5 3500, HyperX 8GB DDR4 RAM, 512GB PCIe NVMe SSD, Windows 10 Home, VR Ready, RGB Lighting (GT12-0010, 2020 Model)", true, "OMEN 25L Gaming Desktop PC", 999.0, "" },
                    { 31, null, 1, "AMD Ryzen 7 5700G, 16 GB RAM, 512 GB SSD, Windows 11 Pro, Wi-Fi 5 & Bluetooth Connectivity, 9 USB Ports, Wired Mouse and Keyboard Combo, Pre-Built Tower (TP01-2022, 2021)", true, "HP Pavilion Desktop PC", 809.0, "" },
                    { 40, null, 4, "Samsung Flagship mobile phone with 256GB", true, "Samsung Galaxy S22 Ultra", 1000.0, "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" },
                    { 30, null, 1, "AMD Ryzen 7 5800X, GeForce RTX 3070, 16GB DDR4 RAM, 1TB SSD, Windows 10 Home, GA15DK-DS776", true, "ROG Strix GA15 Gaming Desktop PC", 1864.0, "" },
                    { 28, null, 1, "Liquid-Cooled (AMD Ryzen 9 5900X 12-Core, 32GB DDR4, 1TB PCIe SSD + 1TB HDD (3.5), GeForce RTX 3070 8GB, WRGB Fans, AC WiFi, BT, Win 10 Pro)", true, "Velztorm Gladio CTO Powerful Gaming Desktop PC", 2264.0, "" },
                    { 12, null, 1, "Geforce RTX 3060 2022 HP Pavilion Gaming Desktop PC, 32GB RAM, 1TB SSD+2TB HDD, Intel i5-10400F, Wired Mouse & Keyboard, Bluetooth, Wi-Fi, USB Type-C, Display Port, HDMI, Windows 11, Mouse Pad", true, "2022 HP Pavilion Gaming Desktop PC", 1230.0, "" },
                    { 13, null, 1, "ntel Core-i5 10400F 2.9GHz, RTX 3060 12GB GDDR6, 16GB DDR4 3000, 1TB SSD, 600W Gold PSU, AC WiFi, Windows 10", true, "Skytech Shadow 3.0 Gaming PC Desktop", 1239.0, "" },
                    { 14, null, 1, "Intel Core i5-11400F 2.6GHz, 8GB DDR4, GeForce RTX 2060 6GB, 500GB NVMe SSD, WiFi Ready & Win 11 Home (GXiVR8060A11)", true, "CYBERPOWERPC Gamer Xtreme VR Gaming PC", 979.0, "" },
                    { 15, null, 1, "NVIDIA GeForce GTX 1650 SUPER, Intel Core i3-10100, 8 GB DDR4 RAM, 256 GB PCIe NVMe SSD, Windows 11, USB Mouse and Keyboard, Compact Tower Design (TG01-1022, 2020)", true, "HP Pavilion Gaming Desktop", 674.0, "" },
                    { 16, null, 1, "Intel Core i7-12700F, 16GB DDR5 RAM, 512GB SSD + 1TB HDD, RTX 3060Ti LHR 8GB GDDR6, Air Cooled, USB-C, Killer WiFi 6, Bluetooth 5.2, Windows 11 Home - White", true, "Alienware Aurora R13 Gaming Desktop", 1989.0, "" },
                    { 17, null, 1, "Liquid-Cooled (AMD Ryzen 7-5800X 8-Core, GeForce RTX 3060 12GB, 32GB DDR4, 512GB PCIe SSD + 2TB HDD (3.5), WiFi-N, RGB Fans, 750W PSU, Win 10 Home)", true, "Velztorm Galax CTO SFF Gaming Desktop PC", 1799.0, "" },
                    { 18, null, 1, "Liquid-Cooled (AMD Ryzen 9 5900X 12-Core, 128GB DDR4, 8TB PCIe SSD + 6TB HDD (3.5), GeForce RTX 3090 24GB, WRGB Fans, AC WiFi, BT, Win 10 Home)", true, "Velztorm Gladio CTO Powerful Gaming Desktop PC", 9478.0, "" },
                    { 29, null, 1, "AMD Ryzen 9 5950X 16-Core/32-Thread Processor, 32GB ARGB 3200MHz DDR4, NVIDIA GeForce RTX 3080 12GB, 2TB M.2 NVMe SSD, WiFi + Bluetooth, Windows 11", true, "MEK Hero G1 A5938V2 Gaming Desktop Powered by ZOTAC", 3101.9899999999998, "" },
                    { 19, null, 1, "Intel Core i5 6500 3.2GHz, TechMagnet Siwa 6 with AMD RX-550 4GB DDR5, 16GB RAM, 256GB SSD, HDMI, DVI, VGA, RGB Keyboard, Mouse, Wi-Fi, Windows 10 Professional (Renewed)", true, "Gaming PC Desktop, TechMagnet Siwa 6", 459.0, "" },
                    { 21, null, 1, "Intel i7 3.40GHz,16GB Ram,New 256GB SSD,Windows 10 Home,WiFi Ready,Video Card GT 1030 2GB, RGB Fans,80+ 500W Power Supply", true, "TJJ Halo Gaming PC Desktop Computer", 599.0, "" },
                    { 22, null, 1, "AMD Octa-Core Ryzen 7 5800X (Beats i9-10900X) 64GB RAM 1TB SSD + 1TB HDD GeForce RTX 3070 8GB Graphic DisplayPort DVI Win10 Black + HDMI Cable", true, "ASUS ROG Strix GA15 Gaming Desktop Computer", 2499.0, "" },
                    { 23, null, 1, "Intel Core i9 12900K 3.2 GHz, RTX 3090, 1TB NVME Gen4 SSD, 32G DDR5 RGB, 850W Gold PSU, 360mm AIO, AC Wi-Fi, Windows 10 Home 64-bit", true, "Skytech Prism II Gaming PC Desktop", 4499.0, "" },
                    { 24, null, 1, "Liquid-Cooled (AMD Ryzen 7-5800X 8-Core, Radeon RX 6900 XT 16GB, 128GB DDR4, 8TB PCIe SSD+6TB HDD (3.5), WiFi-N, RGB Fans, 750W PSU, Black, Win 10 Pro)", true, "Velztorm Galax CTO SFF Gaming Desktop PC", 9548.0, "" },
                    { 25, null, 1, "Intel i7-11700 - 32GB RAM, 512GB NVMe SSD + 1TB HDD - Nvidia Geforce RTX 3060 Ti 8GB 4K, DisplayPort, HDMI, DVD, AX Wi-Fi, Bluetooth, SD Card - Windows 10 Pro (Renewed)", true, "Dell XPS 8940 Gaming Tower PC", 1463.4000000000001, "" },
                    { 26, null, 1, "Ryzen 5 3600 6-Core 3.6GHz, RTX 3060 12GB, 1TB SSD, 16GB DDR4 3000, RGB Fans, AC WiFi, 600W Gold PSU, Windows 10 Home 64-bit, Black", true, "SkyTech Shadow 3.0 Gaming Computer PC Desktop", 1199.99, "" },
                    { 27, null, 1, "AMD Ryzen 7 5800, NVIDIA GeForce RTX 3070 8GB GDDR6, 16GB 3466MHz RAM, 512GB SSD + 1TB HDD, Air Cooled, Wi-Fi 6, Bluetooth, USB-C, Windows 11 Home - Black", true, "Alienware Aurora R14 VR Ready Gaming PC", 1800.96, "" },
                    { 20, null, 1, "AMD Ryzen 5 5600X 3.7GHz, GeForce RTX 3060 12GB, 16GB DDR4 RAM, 1TB NVMe SSD, WiFi Ready & Win 10 Home (GMA1410A3)", true, "CYBERPOWERPC Gamer Master Gaming PC", 2021.0, "" },
                    { 11, null, 1, "Gaming Laptop, 15.6inch Full HD IPS, Intel i7 CPU, 16GB DDR4 RAM, 256GB SSD, GeForce GTX 1060-6GB, VR Ready, Red Backlit KB, Metal Chassis, Windows 10 64-bit, G3-571-77QK", true, "Acer Predator Helios 300 Gaming Laptop", 1278.0, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "A gaming laptop with great performance", "ASUS Laptop", 1000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "A gaming laptop with great performance", "Acer Laptop", 900.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "A descktop pc with great performance", "iMac Retina", 1500.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", 1000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "High performance speaker system that produces 50 Watts of raw, rock solid audio power", "Creative SBS E2800 2.1 High Performance Speakers System - Black", 55.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 3, "4-Series 4K UHD smart TV", "Amazon Fire TV 43", 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 3, "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", "Pioneer 43-inch", 210.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Description", "InStock", "Name", "Price" },
                values: new object[] { 4, "Apple Flagship mobile phone with 256GB", false, "iPhone 13 Pro Max", 1200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Description", "Name", "Price", "URL" },
                values: new object[] { 4, "Samsung Flagship mobile phone with 256GB", "Samsung Galaxy S22 Ultra", 1000.0, "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" });
        }
    }
}
