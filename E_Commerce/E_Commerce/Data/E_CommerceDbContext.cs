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
        //public DbSet<Cart> Cart { get; set; }
        //public DbSet<ProductCart> ProductCart { get; set; }

        public E_CommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData
                (
                new Category { ID = 1, Name = "PC && Laptops", Description = "Find all PCs and Laptops in our store here!" },
                new Category { ID = 2, Name = "Audio Devices", Description = "Find Speakers and headsets in our store here!" },
                new Category { ID = 3, Name = "PC && Laptops", Description = "Find all Televitions in our store here!" },
                new Category { ID = 4, Name = "Mobile Phones", Description = "Find all moblie devices in our store here!" }
                );

            modelBuilder.Entity<Product>().HasData
                (
                new Product { ID = 1, Name = "ASUS Laptop", InStock = true, Price = 1000, Description = "A gaming laptop with great performance", CategoryID = 1, URL=""},
                new Product { ID = 2, Name = "Acer Laptop", InStock = true, Price = 900, Description = "A gaming laptop with great performance", CategoryID = 1, URL = "" },
                new Product { ID = 3, Name = "iMac Retina", InStock = true, Price = 1500, Description = "A descktop pc with great performance", CategoryID = 1, URL = "" },
                new Product { ID = 4, Name = "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", InStock = true, Price = 1000, Description = "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", CategoryID = 1, URL = "" },
                new Product { ID = 5, Name = "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", InStock = true, Price = 100, Description = "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", CategoryID = 2, URL = "" },
                new Product { ID = 6, Name = "Creative SBS E2800 2.1 High Performance Speakers System - Black", InStock = true, Price = 55, Description = "High performance speaker system that produces 50 Watts of raw, rock solid audio power", CategoryID = 2, URL = "" },
                new Product { ID = 7, Name = "Amazon Fire TV 43", InStock = true, Price = 250, Description = "4-Series 4K UHD smart TV", CategoryID = 3, URL = "" },
                new Product { ID = 8, Name = "Pioneer 43-inch", InStock = true, Price = 210, Description = "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", CategoryID = 3, URL = "" },
                new Product { ID = 9, Name = "iPhone 13 Pro Max", InStock = false, Price = 1200, Description = "Apple Flagship mobile phone with 256GB", CategoryID = 4, URL = "" },
                new Product { ID = 10, Name = "Samsung Galaxy S22 Ultra", InStock = true, Price = 1000, Description = "Samsung Flagship mobile phone with 256GB", CategoryID = 4, URL= "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" }
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
            //modelBuilder.Entity<ProductCart>().HasKey(x => new { x.CartID, x.ProductID });
            //modelBuilder.Entity<ApplicationUser>()
            //.HasOne(a => a.Cart)
            //.WithOne(a => a.User)
            //.HasForeignKey<Cart>(c => c.UserID);
        }
    }
}