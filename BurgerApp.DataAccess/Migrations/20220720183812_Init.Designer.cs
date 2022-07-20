﻿// <auto-generated />
using BurgerApp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    [Migration("20220720183812_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegeterian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            IsVegan = false,
                            IsVegeterian = false,
                            Name = "Hamburger",
                            Price = 150.0
                        },
                        new
                        {
                            Id = 2,
                            HasFries = true,
                            IsVegan = false,
                            IsVegeterian = false,
                            Name = "Cheeseburger",
                            Price = 180.0
                        },
                        new
                        {
                            Id = 3,
                            HasFries = true,
                            IsVegan = false,
                            IsVegeterian = true,
                            Name = "Vegeburger",
                            Price = 140.0
                        },
                        new
                        {
                            Id = 4,
                            HasFries = false,
                            IsVegan = true,
                            IsVegeterian = true,
                            Name = "Veganburger",
                            Price = 200.0
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("BurgerOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurgerId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            BurgerId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            BurgerId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 4,
                            BurgerId = 3,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 5,
                            BurgerId = 4,
                            OrderId = 3
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelivered = false,
                            PaymentMethod = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDelivered = false,
                            PaymentMethod = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            IsDelivered = false,
                            PaymentMethod = 2,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ul.France Preshern br.46",
                            FirstName = "Kristijan",
                            LastName = "Karanfilovski",
                            Location = "Vlae"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Radishani Hills br. 10",
                            FirstName = "Ilija",
                            LastName = "Mitev",
                            Location = "Radishani"
                        },
                        new
                        {
                            Id = 3,
                            Address = "ul.Sparkling Water br. 99",
                            FirstName = "Aneta",
                            LastName = "Stankovska",
                            Location = "Kisela voda"
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Burger", "Burger")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerApp.Domain.Models.Order", "Order")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Navigation("BurgerOrders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Navigation("BurgerOrders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}