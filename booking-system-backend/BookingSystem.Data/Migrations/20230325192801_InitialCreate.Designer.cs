﻿// <auto-generated />
using System;
using BookingSystem.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingSystem.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230325192801_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Shared.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReservedPeople")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateFrom = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 2,
                            RoomId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateFrom = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 1,
                            RoomId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateFrom = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 3,
                            RoomId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateFrom = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 2,
                            RoomId = 4
                        },
                        new
                        {
                            Id = 5,
                            DateFrom = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 1,
                            RoomId = 5
                        },
                        new
                        {
                            Id = 6,
                            DateFrom = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 2,
                            RoomId = 6
                        },
                        new
                        {
                            Id = 7,
                            DateFrom = new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 2,
                            RoomId = 7
                        },
                        new
                        {
                            Id = 8,
                            DateFrom = new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservedPeople = 1,
                            RoomId = 8
                        });
                });

            modelBuilder.Entity("Shared.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Single Bed",
                            NumberOfPeople = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Double Bed",
                            NumberOfPeople = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Twin Bed",
                            NumberOfPeople = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Triple",
                            NumberOfPeople = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Quad",
                            NumberOfPeople = 4
                        },
                        new
                        {
                            Id = 6,
                            Name = "Queen Room",
                            NumberOfPeople = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "King Room",
                            NumberOfPeople = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Suite",
                            NumberOfPeople = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
