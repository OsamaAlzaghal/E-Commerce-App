using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class E_CommerceDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public E_CommerceDbContext( DbContextOptions options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductCart>().HasKey(x => new { x.CartID, x.ProductID });


            modelBuilder.Entity<Category>().HasData
                (
                new Category { ID = 1, Name = "PC && Laptops", Description= "Find all PCs and Laptops in our store here!"},
                new Category { ID = 2, Name = "Audio Devices", Description = "Find Speakers and headsets in our store here!" },
                new Category { ID = 3, Name = "PC && Laptops", Description = "Find all Televitions in our store here!" },
                new Category { ID = 4, Name = "Mobile Phones", Description = "Find all moblie devices in our store here!"}
                );



            modelBuilder.Entity<Product>().HasData
                (
                new Product { ID = 1, Name= "ASUS Laptop", InStock = true, Price = 1000, Description= "A gaming laptop with great performance", CategoryID = 1},
                new Product { ID = 2, Name = "Acer Laptop", InStock = true, Price = 900, Description = "A gaming laptop with great performance", CategoryID = 1 },
                new Product { ID = 3, Name = "iMac Retina", InStock = true, Price = 1500, Description = "A descktop pc with great performance", CategoryID = 1 },
                new Product { ID = 4, Name= "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", InStock = true, Price = 1000, Description= "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card," , CategoryID = 1},
                new Product { ID = 5, Name = "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", InStock = true, Price = 100, Description = "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", CategoryID = 2 },
                new Product { ID = 6, Name = "Creative SBS E2800 2.1 High Performance Speakers System - Black", InStock = true, Price = 55, Description = "High performance speaker system that produces 50 Watts of raw, rock solid audio power", CategoryID = 2 },
                new Product { ID = 7, Name = "Amazon Fire TV 43", InStock = true, Price = 250, Description = "4-Series 4K UHD smart TV", CategoryID = 3 },
                new Product { ID = 8, Name = "Pioneer 43-inch", InStock = true, Price = 210, Description = "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", CategoryID = 3 },
                new Product { ID = 9, Name = "iPhone 13 Pro Max" , InStock = false, Price = 1200, Description = "Apple Flagship mobile phone with 256GB", CategoryID = 4},
                new Product { ID = 10, Name = "Samsung Galaxy S22 Ultra", InStock = true, Price = 1000, Description = "Samsung Flagship mobile phone with 256GB", CategoryID = 4 }

                );

            modelBuilder.Entity<User>().HasData
                (
                new User { ID = 1, Name = "Laith Alamat", Email = "laithalamat@LTUC.com", Password = "12345", PhoneNumber = "0777"},
                new User { ID = 2, Name = "Osama Alzaghal", Email = "osamaalzaghal@LTUC.com", Password = "12345", PhoneNumber = "0778"}
                );

        }
    }
}