using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReservedPeople = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DateFrom", "DateTo", "ReservedPeople", "RoomId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 5, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 6, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 7, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 8, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "NumberOfPeople" },
                values: new object[,]
                {
                    { 1, "Single Bed", 1 },
                    { 2, "Double Bed", 2 },
                    { 3, "Twin Bed", 2 },
                    { 4, "Triple", 3 },
                    { 5, "Quad", 4 },
                    { 6, "Queen Room", 2 },
                    { 7, "King Room", 2 },
                    { 8, "Suite", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
