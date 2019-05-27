﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yachtos.Database;

namespace Yachtos.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("Yachtos.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemsId");

                    b.HasKey("CartId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Yachtos.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Yachtos.Models.Favorites", b =>
                {
                    b.Property<int>("FavoritesId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemsId");

                    b.Property<int>("UserId");

                    b.HasKey("FavoritesId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Yachtos.Models.Items", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CartId");

                    b.Property<int>("StorageId");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.HasIndex("CartId");

                    b.HasIndex("StorageId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Yachtos.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("busena");

                    b.Property<string>("descprition");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Yachtos.Models.Packages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Yachtos.Models.PackagesItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Fk_packagesid");

                    b.Property<int>("ItemsId");

                    b.Property<int>("PackageId");

                    b.HasKey("id");

                    b.HasIndex("Fk_packagesid");

                    b.HasIndex("ItemsId");

                    b.ToTable("PackagesItems");
                });

            modelBuilder.Entity("Yachtos.Models.Storage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Item");

                    b.Property<string>("description");

                    b.Property<int>("kiekis");

                    b.HasKey("id");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("Yachtos.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("Teises");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Yachtos.Models.Employee", b =>
                {
                    b.HasOne("Yachtos.Models.User", "fk_User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Yachtos.Models.Items", b =>
                {
                    b.HasOne("Yachtos.Models.Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("Yachtos.Models.Storage", "fk_storage")
                        .WithMany()
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Yachtos.Models.PackagesItems", b =>
                {
                    b.HasOne("Yachtos.Models.Packages", "Fk_packages")
                        .WithMany()
                        .HasForeignKey("Fk_packagesid");

                    b.HasOne("Yachtos.Models.Items", "Fk_item")
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
