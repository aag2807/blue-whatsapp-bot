using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreatedUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 162, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 158, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 163, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 42, 1, 166, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTime", "Email", "IsActive", "ModifiedTime", "Name", "Password" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", true, null, "Admin", "$2a$11$Ir1//6Sz6SGS.JGXUuwAU.ovi6wdLjt0MrBYM5j5eN17kFHMSG5bC" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 648, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 650, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2025, 4, 8, 14, 13, 59, 652, DateTimeKind.Utc).AddTicks(3179));
        }
    }
}
