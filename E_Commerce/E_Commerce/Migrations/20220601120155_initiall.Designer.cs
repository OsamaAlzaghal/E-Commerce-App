﻿// <auto-generated />
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce.Migrations
{
    [DbContext(typeof(E_CommerceDbContext))]
    [Migration("20220601120155_initiall")]
    partial class initiall
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("E_Commerce.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Find all PCs and Laptops in our store here!",
                            Name = "PC && Laptops"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Find Speakers and headsets in our store here!",
                            Name = "Audio Devices"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Find all Televitions in our store here!",
                            Name = "PC && Laptops"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Find all moblie devices in our store here!",
                            Name = "Mobile Phones"
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartID")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Description = "A gaming laptop with great performance",
                            InStock = true,
                            Name = "ASUS Laptop",
                            Price = 1000.0
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Description = "A gaming laptop with great performance",
                            InStock = true,
                            Name = "Acer Laptop",
                            Price = 900.0
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            Description = "A descktop pc with great performance",
                            InStock = true,
                            Name = "iMac Retina",
                            Price = 1500.0
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 1,
                            Description = "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,",
                            InStock = true,
                            Name = "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch",
                            Price = 1000.0
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 2,
                            Description = "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts",
                            InStock = true,
                            Name = "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified",
                            Price = 100.0
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 2,
                            Description = "High performance speaker system that produces 50 Watts of raw, rock solid audio power",
                            InStock = true,
                            Name = "Creative SBS E2800 2.1 High Performance Speakers System - Black",
                            Price = 55.0
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            Description = "4-Series 4K UHD smart TV",
                            InStock = true,
                            Name = "Amazon Fire TV 43",
                            Price = 250.0
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            Description = "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)",
                            InStock = true,
                            Name = "Pioneer 43-inch",
                            Price = 210.0
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 4,
                            Description = "Apple Flagship mobile phone with 256GB",
                            InStock = false,
                            Name = "iPhone 13 Pro Max",
                            Price = 1200.0
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 4,
                            Description = "Samsung Flagship mobile phone with 256GB",
                            InStock = true,
                            Name = "Samsung Galaxy S22 Ultra",
                            Price = 1000.0
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.ProductCart", b =>
                {
                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCarts");
                });

            modelBuilder.Entity("E_Commerce.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "laithalamat@LTUC.com",
                            Name = "Laith Alamat",
                            Password = "12345",
                            PhoneNumber = "0777"
                        },
                        new
                        {
                            ID = 2,
                            Email = "osamaalzaghal@LTUC.com",
                            Name = "Osama Alzaghal",
                            Password = "12345",
                            PhoneNumber = "0778"
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.Cart", b =>
                {
                    b.HasOne("E_Commerce.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("E_Commerce.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.Models.Payment", b =>
                {
                    b.HasOne("E_Commerce.Models.Cart", "Cart")
                        .WithOne("Payment")
                        .HasForeignKey("E_Commerce.Models.Payment", "CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.HasOne("E_Commerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commerce.Models.ProductCart", b =>
                {
                    b.HasOne("E_Commerce.Models.Cart", "Cart")
                        .WithMany("ProductCarts")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Models.Product", "Product")
                        .WithMany("ProductCarts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Models.Cart", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("ProductCarts");
                });

            modelBuilder.Entity("E_Commerce.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.Navigation("ProductCarts");
                });

            modelBuilder.Entity("E_Commerce.Models.User", b =>
                {
                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
