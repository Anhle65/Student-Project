﻿// <auto-generated />
using System;
using CommercialWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommercialWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118091842_AddFoodAndInformation")]
    partial class AddFoodAndInformation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CommercialWeb.Models.Categories", b =>
                {
                    b.Property<byte>("CategoryId")
                        .HasColumnType("tinyint");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = (byte)1,
                            CategoryName = "Food"
                        },
                        new
                        {
                            CategoryId = (byte)2,
                            CategoryName = "Book"
                        },
                        new
                        {
                            CategoryId = (byte)3,
                            CategoryName = "Furniture"
                        });
                });

            modelBuilder.Entity("CommercialWeb.Models.Foods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            InStock = true,
                            Price = 7.5,
                            ProductName = "Apple Pie"
                        },
                        new
                        {
                            Id = 12,
                            InStock = true,
                            Price = 3.5,
                            ProductName = "Garlic"
                        },
                        new
                        {
                            Id = 13,
                            InStock = true,
                            Price = 5.0,
                            ProductName = "Banana"
                        },
                        new
                        {
                            Id = 14,
                            InStock = false,
                            Price = 10.59,
                            ProductName = "Carrot Cake"
                        },
                        new
                        {
                            Id = 15,
                            InStock = false,
                            Price = 11.35,
                            ProductName = "Salmon"
                        });
                });

            modelBuilder.Entity("CommercialWeb.Models.Information", b =>
                {
                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BestBefore")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductType");

                    b.HasIndex("FoodId")
                        .IsUnique();

                    b.ToTable("Information");

                    b.HasData(
                        new
                        {
                            ProductType = "Pie",
                            BestBefore = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 11,
                            Storage = "Under 7 degree",
                            Usage = "Reheat"
                        },
                        new
                        {
                            ProductType = "Herb",
                            BestBefore = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 12,
                            Storage = "23 degree",
                            Usage = "Directly"
                        },
                        new
                        {
                            ProductType = "Fruit",
                            BestBefore = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 13,
                            Storage = "23 degree",
                            Usage = "Directly"
                        },
                        new
                        {
                            ProductType = "Cake",
                            BestBefore = new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 14,
                            Storage = "Under 7 degree",
                            Usage = "Directly"
                        },
                        new
                        {
                            ProductType = "Fish",
                            BestBefore = new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 15,
                            Storage = "Under 5 degree",
                            Usage = "Reheat and Cook"
                        });
                });

            modelBuilder.Entity("CommercialWeb.Models.Information", b =>
                {
                    b.HasOne("CommercialWeb.Models.Foods", "Foods")
                        .WithOne("Information")
                        .HasForeignKey("CommercialWeb.Models.Information", "FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Foods");
                });

            modelBuilder.Entity("CommercialWeb.Models.Foods", b =>
                {
                    b.Navigation("Information")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
