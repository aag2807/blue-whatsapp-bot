using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedNewFieldsForReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdultsCount",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChildrenCount",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reservations",
                type: "TEXT",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OriginalReservationId",
                table: "Reservations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                table: "Reservations",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatusReason",
                table: "Reservations",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 214, DateTimeKind.Utc).AddTicks(2291), new DateTime(2025, 6, 2, 20, 9, 51, 214, DateTimeKind.Utc).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 6, 2, 20, 9, 51, 284, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 249, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 6, 2, 20, 9, 51, 250, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 6, 2, 20, 9, 51, 298, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 6, 2, 20, 9, 51, 313, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(3727), new DateTime(2025, 6, 2, 20, 9, 51, 316, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 317, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 6, 2, 20, 9, 51, 317, DateTimeKind.Utc).AddTicks(7672), "$2a$11$D9sXCzPkYN4TzHjg1zYUfOfusbUMj1d7.MrTOZMyv9v7KlZJvvadS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 684, DateTimeKind.Utc).AddTicks(4816), new DateTime(2025, 6, 2, 20, 9, 51, 684, DateTimeKind.Utc).AddTicks(4820), "$2a$11$yRKAN./Te0wl2.OozV/Q9eoqEAiDzYu5WfxHVuURpR61ECLQPVBe2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 51, 942, DateTimeKind.Utc).AddTicks(6669), new DateTime(2025, 6, 2, 20, 9, 51, 942, DateTimeKind.Utc).AddTicks(6677), "$2a$11$wjNsCwH3eHFqQr2sfE4GXu70T6xZd6H1KV1nohO.OLa4pFh1rIy8W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 9, 52, 262, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 6, 2, 20, 9, 52, 262, DateTimeKind.Utc).AddTicks(7571), "$2a$11$xsv9cmJkPQ75oSO7o5paE.ro26E7T1zKXkQZ3ku1Pj0XY5LjFP8bi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdultsCount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ChildrenCount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "OriginalReservationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StatusReason",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 143, DateTimeKind.Utc).AddTicks(2605), new DateTime(2025, 5, 13, 17, 57, 50, 143, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 5, 13, 17, 57, 50, 184, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 157, DateTimeKind.Utc).AddTicks(9113), new DateTime(2025, 5, 13, 17, 57, 50, 158, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 191, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 13, 17, 57, 50, 192, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 5, 13, 17, 57, 50, 207, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 214, DateTimeKind.Utc).AddTicks(1096), new DateTime(2025, 5, 13, 17, 57, 50, 214, DateTimeKind.Utc).AddTicks(1098), "$2a$11$sKDmvioZXzl.jhZrxMi93O9ZHoqAJt5cKRKhb9RiZVYhQFlbVuq0S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 50, 550, DateTimeKind.Utc).AddTicks(601), new DateTime(2025, 5, 13, 17, 57, 50, 550, DateTimeKind.Utc).AddTicks(605), "$2a$11$fggoKmo2V4ca3ey84Gurvuj/juD11ScanBm4mXfv/e0Oh3aOjOCaK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 51, 278, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 5, 13, 17, 57, 51, 278, DateTimeKind.Utc).AddTicks(2238), "$2a$11$pD27tg2kwzs.G00dTpxqn.VhrUtnmmmkYaozYsQj1xvLxA0eld7JW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 57, 51, 744, DateTimeKind.Utc).AddTicks(6516), new DateTime(2025, 5, 13, 17, 57, 51, 744, DateTimeKind.Utc).AddTicks(6520), "$2a$11$kYXf5qB/icZ5RpNm1erTa.zwLnYVR2mQggU1UEIs7to0GILd6tM2a" });
        }
    }
}
