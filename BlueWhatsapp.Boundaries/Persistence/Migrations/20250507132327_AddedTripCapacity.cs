using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedTripCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxCapacity",
                table: "Trips",
                type: "INTEGER",
                nullable: false,
                defaultValue: 30);

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 63, DateTimeKind.Utc).AddTicks(5242), new DateTime(2025, 5, 7, 13, 23, 26, 63, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 70, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 5, 7, 13, 23, 26, 71, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 5, 7, 13, 23, 26, 68, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6183), new DateTime(2025, 5, 7, 13, 23, 26, 72, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 5, 7, 13, 23, 26, 74, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "MaxCapacity", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), 30, new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 78, DateTimeKind.Utc).AddTicks(4118), new DateTime(2025, 5, 7, 13, 23, 26, 78, DateTimeKind.Utc).AddTicks(4119), "$2a$11$DzNArZmQNxft4YBHsEs5fOrbOjErTL48dFaR92oxF1dwxlvZBDBoS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 215, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 5, 7, 13, 23, 26, 215, DateTimeKind.Utc).AddTicks(7799), "$2a$11$CLQXKgCxh.7PEYB/XHjBGuePFALQl4FbohPcty.jJ7KphWlc3xvE." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 365, DateTimeKind.Utc).AddTicks(91), new DateTime(2025, 5, 7, 13, 23, 26, 365, DateTimeKind.Utc).AddTicks(96), "$2a$11$dIWlQmhz/4NmIpqvPiNzgu2dCgEwJa3hyji2kcs5Xs6t2SG3h2NmO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 495, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 5, 7, 13, 23, 26, 495, DateTimeKind.Utc).AddTicks(9154), "$2a$11$OaEVh0ZJwWDWDS8zGK8kQOO6VblMmhJG0rgyzKS55qXyR6Sh.t2um" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCapacity",
                table: "Trips");

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 94, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 5, 1, 18, 4, 37, 94, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 5, 1, 18, 4, 37, 102, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 1, 18, 4, 37, 98, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 5, 1, 18, 4, 37, 104, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 5, 1, 18, 4, 37, 106, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 5, 1, 18, 4, 37, 110, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 111, DateTimeKind.Utc).AddTicks(2347), new DateTime(2025, 5, 1, 18, 4, 37, 111, DateTimeKind.Utc).AddTicks(2348), "$2a$11$ze6VJcznO.me2NDD4530uuyD6sinvwZ2VltonNh3grnDqbxpcR176" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 294, DateTimeKind.Utc).AddTicks(1401), new DateTime(2025, 5, 1, 18, 4, 37, 294, DateTimeKind.Utc).AddTicks(1409), "$2a$11$kUz4ULUi/HLl4d8fuw7AGu4CxD3/98OiqoQ09om6n8SDYNWF8o5XC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 470, DateTimeKind.Utc).AddTicks(5659), new DateTime(2025, 5, 1, 18, 4, 37, 470, DateTimeKind.Utc).AddTicks(5667), "$2a$11$6OUrbJHbiAeM7LRMIvAXbePONIDhDoBSm7583cDxi7RrX/OZ0wVSK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 4, 37, 636, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 5, 1, 18, 4, 37, 636, DateTimeKind.Utc).AddTicks(4684), "$2a$11$lQh1TI3TWG.dCF8W0d/wAOdkhANj2Xs6H3OvORPOTTiBI8uySH.UK" });
        }
    }
}
