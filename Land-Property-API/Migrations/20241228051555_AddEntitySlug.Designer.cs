﻿// <auto-generated />
using System;
using Land_Property.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Land_Property.API.Migrations
{
    [DbContext(typeof(PropertyDatabaseContext))]
    [Migration("20241228051555_AddEntitySlug")]
    partial class AddEntitySlug
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Land_Property.API.Entities.AdvertisementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("AdvertisementTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(5856),
                            Name = "Rent",
                            Slug = "rent",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6093)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6731),
                            Name = "Sell",
                            Slug = "sell",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6732)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6733),
                            Name = "Credit",
                            Slug = "credit",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6734)
                        });
                });

            modelBuilder.Entity("Land_Property.API.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdvertisementTypeId")
                        .HasColumnType("int");

                    b.Property<byte>("Bathroom")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Bedroom")
                        .HasColumnType("tinyint");

                    b.Property<float>("BuildingArea")
                        .HasColumnType("real");

                    b.Property<int>("BuildingTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Floor")
                        .HasColumnType("tinyint");

                    b.PrimitiveCollection<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementTypeId");

                    b.HasIndex("BuildingTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Land_Property.API.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 801, DateTimeKind.Local).AddTicks(6311),
                            Name = "House",
                            Slug = "house",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(8846)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9735),
                            Name = "Apartment",
                            Slug = "apartment",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9738)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9739),
                            Name = "Guesthouse",
                            Slug = "guesthouse",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9740)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9741),
                            Name = "Warehouse",
                            Slug = "warehouse",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9742)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9743),
                            Name = "Commercial",
                            Slug = "commercial",
                            UpdatedAt = new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9744)
                        });
                });

            modelBuilder.Entity("Land_Property.API.Entities.PropertyViewLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("PropertyViewLogs");
                });

            modelBuilder.Entity("Land_Property.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Land_Property.API.Entities.UserSessionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSessionLogs");
                });

            modelBuilder.Entity("Land_Property.API.Entities.Property", b =>
                {
                    b.HasOne("Land_Property.API.Entities.AdvertisementType", "AdvertisementType")
                        .WithMany()
                        .HasForeignKey("AdvertisementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Land_Property.API.Entities.PropertyType", "BuildingType")
                        .WithMany()
                        .HasForeignKey("BuildingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Land_Property.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdvertisementType");

                    b.Navigation("BuildingType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Land_Property.API.Entities.PropertyViewLog", b =>
                {
                    b.HasOne("Land_Property.API.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Land_Property.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Land_Property.API.Entities.UserSessionLog", b =>
                {
                    b.HasOne("Land_Property.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}