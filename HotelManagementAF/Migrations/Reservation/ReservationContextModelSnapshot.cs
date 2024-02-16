﻿// <auto-generated />
using System;
using HotelManagementAF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagementAF.Migrations
{
    [DbContext(typeof(ReservationContext))]
    partial class ReservationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagementAF.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AptSuite")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthDay")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BreakFast")
                        .HasColumnType("int");

                    b.Property<string>("CardCvc")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("CardExp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<bool>("CheckIn")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(-1)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cleaning")
                        .HasColumnType("bit");

                    b.Property<int>("Dinner")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(-1)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FoodBill")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Launch")
                        .HasColumnType("int");

                    b.Property<DateTime>("LeavingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumberGuest")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoomFloor")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(-1)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SupplyStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("Surprise")
                        .HasColumnType("bit");

                    b.Property<double>("TotalBill")
                        .HasColumnType("float");

                    b.Property<bool>("Towel")
                        .HasColumnType("bit");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Reservation", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
