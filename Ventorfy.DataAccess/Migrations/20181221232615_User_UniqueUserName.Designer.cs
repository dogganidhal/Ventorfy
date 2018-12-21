﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ventorfy.DataAccess;

namespace Ventorfy.DataAccess.Migrations
{
    [DbContext(typeof(VentorfyDbContext))]
    [Migration("20181221232615_User_UniqueUserName")]
    partial class User_UniqueUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Inventory.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Inventory.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.ClientOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("Date");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("ClientOrders");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientOrderId");

                    b.Property<int>("Count");

                    b.Property<int>("ProductId");

                    b.Property<int?>("ProviderOrderId");

                    b.HasKey("Id");

                    b.HasIndex("ClientOrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProviderOrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.ProviderOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("ProviderId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProviderOrders");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<double>("Price");

                    b.Property<int?>("ProviderId");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Products.ProductLot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("ProductLots");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("UserName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Inventory.Store", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Users.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.ClientOrder", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Users.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.OrderItem", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Orders.ClientOrder")
                        .WithMany("Items")
                        .HasForeignKey("ClientOrderId");

                    b.HasOne("Ventorfy.DataAccess.Model.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ventorfy.DataAccess.Model.Orders.ProviderOrder")
                        .WithMany("Items")
                        .HasForeignKey("ProviderOrderId");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Orders.ProviderOrder", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Users.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ventorfy.DataAccess.Model.Inventory.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Products.Product", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Products.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ventorfy.DataAccess.Model.Inventory.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId");
                });

            modelBuilder.Entity("Ventorfy.DataAccess.Model.Products.ProductLot", b =>
                {
                    b.HasOne("Ventorfy.DataAccess.Model.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ventorfy.DataAccess.Model.Inventory.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
