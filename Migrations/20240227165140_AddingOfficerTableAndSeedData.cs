using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KunschickMidterm452.Migrations
{
    /// <inheritdoc />
    public partial class AddingOfficerTableAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Officers",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DLN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officers", x => x.OfficerId);
                });

            migrationBuilder.InsertData(
                table: "Officers",
                columns: new[] { "OfficerId", "Address", "DLN", "DOB", "FirstName", "LastName", "PhoneNum", "StartDate" },
                values: new object[,]
                {
                    { 1, "1776 Main St", "85891642", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Washington", "3045151776", new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "1800 Beechurst Ave", "74326681", new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", "Jefferson", "3048549120", new DateTime(2017, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "15 University Ave", "74326681", new DateTime(1977, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Adams", "3047811659", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Officers");
        }
    }
}
