﻿// <auto-generated />
using System;
using KunschickMidterm452.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KunschickMidterm452.Migrations
{
    [DbContext(typeof(PoliceDbContext))]
    [Migration("20240227165140_AddingOfficerTableAndSeedData")]
    partial class AddingOfficerTableAndSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KunschickMidterm452.Models.Officer", b =>
                {
                    b.Property<int>("OfficerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DLN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OfficerId");

                    b.ToTable("Officers");

                    b.HasData(
                        new
                        {
                            OfficerId = 1,
                            Address = "1776 Main St",
                            DLN = "85891642",
                            DOB = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "George",
                            LastName = "Washington",
                            PhoneNum = "3045151776",
                            StartDate = new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OfficerId = 2,
                            Address = "1800 Beechurst Ave",
                            DLN = "74326681",
                            DOB = new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Thomas",
                            LastName = "Jefferson",
                            PhoneNum = "3048549120",
                            StartDate = new DateTime(2017, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OfficerId = 3,
                            Address = "15 University Ave",
                            DLN = "74326681",
                            DOB = new DateTime(1977, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            LastName = "Adams",
                            PhoneNum = "3047811659",
                            StartDate = new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
