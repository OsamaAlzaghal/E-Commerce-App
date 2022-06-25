using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class E_CommerceDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        //public DbSet<ProductCart> ProductCart { get; set; }

        public E_CommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData
                (
                new Category { ID = 1, Name = "PC && Laptops", Description = "Find all PCs and Laptops in our store here!", URL = "data:image/png;base64,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" },
                new Category { ID = 2, Name = "Audio Devices", Description = "Find Speakers and headsets in our store here!", URL = "https://i.pinimg.com/736x/48/0c/da/480cda32088d4e5a1c0e4f53a2bb0fbc.jpg" },
                new Category { ID = 3, Name = "Televitions and Monitors", Description = "Find all Televitions in our store here!", URL = "https://i.pinimg.com/736x/5b/6c/d7/5b6cd7388dc2e7825191cfbd31e25c1d.jpg" },
                new Category { ID = 4, Name = "Mobile Phones", Description = "Find all moblie devices in our store here!", URL = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/cell-phone-design-template-608242c6014c909324ec156c32889970_screen.jpg?ts=1581061060" }
                );

            modelBuilder.Entity<Product>().HasData
                (
                new Product { ID = 1, Name = "ASUS Laptop", InStock = true, Price = 1000, Description = "A gaming laptop with great performance", CategoryID = 1, URL = "" },
                new Product { ID = 2, Name = "Acer Laptop", InStock = true, Price = 900, Description = "A gaming laptop with great performance", CategoryID = 1, URL = "" },
                new Product { ID = 3, Name = "iMac Retina", InStock = true, Price = 1500, Description = "A descktop pc with great performance", CategoryID = 1, URL = "" },
                new Product { ID = 4, Name = "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", InStock = true, Price = 1000, Description = "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", CategoryID = 1, URL = "" },
                new Product { ID = 5, Name = "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", InStock = true, Price = 100, Description = "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", CategoryID = 2, URL = "" },
                new Product { ID = 6, Name = "Creative SBS E2800 2.1 High Performance Speakers System - Black", InStock = true, Price = 55, Description = "High performance speaker system that produces 50 Watts of raw, rock solid audio power", CategoryID = 2, URL = "" },
                new Product { ID = 7, Name = "Amazon Fire TV 43", InStock = true, Price = 250, Description = "4-Series 4K UHD smart TV", CategoryID = 3, URL = "" },
                new Product { ID = 8, Name = "Pioneer 43-inch", InStock = true, Price = 210, Description = "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", CategoryID = 3, URL = "" },
                new Product { ID = 9, Name = "iPhone 13 Pro Max", InStock = false, Price = 1200, Description = "Apple Flagship mobile phone with 256GB", CategoryID = 4, URL = "" },
                new Product { ID = 10, Name = "Samsung Galaxy S22 Ultra", InStock = true, Price = 1000, Description = "Samsung Flagship mobile phone with 256GB", CategoryID = 4, URL = "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" }
                );

            SeedRoles(modelBuilder, "administrator", "create", "delete");
            SeedRoles(modelBuilder, "editor", "create", "update");
            SeedRoles(modelBuilder, "user", "create");
        }
        private int id = 1;
        private void SeedRoles(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()

            };
            modelBuilder.Entity<IdentityRole>().HasData(role);

            var RoleClaims = permissions.Select(permission =>
            new IdentityRoleClaim<string>
            {
                Id = id++,
                RoleId = role.Id,
                ClaimType = "permissions",
                ClaimValue = permission
            }
            ).ToArray();

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(RoleClaims);
        }
    }
}