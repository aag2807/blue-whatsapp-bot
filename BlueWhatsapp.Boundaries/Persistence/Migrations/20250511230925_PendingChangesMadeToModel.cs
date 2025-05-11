using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PendingChangesMadeToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtraInformation",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ExtraInformation", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 742, DateTimeKind.Utc).AddTicks(3688), "", new DateTime(2025, 5, 11, 23, 9, 23, 742, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 5, 11, 23, 9, 23, 791, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 11, 23, 9, 23, 778, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 795, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 5, 11, 23, 9, 23, 796, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 5, 11, 23, 9, 23, 807, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(3923), new DateTime(2025, 5, 11, 23, 9, 23, 816, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 23, 819, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 5, 11, 23, 9, 23, 819, DateTimeKind.Utc).AddTicks(8168), "$2a$11$0AZC0BfLbTh5ZmiyaOtXvOjpgaqOQm/LS/36fkiSQWblnE6zpCjSK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 24, 113, DateTimeKind.Utc).AddTicks(4230), new DateTime(2025, 5, 11, 23, 9, 24, 113, DateTimeKind.Utc).AddTicks(4235), "$2a$11$IBBsXdQI4UgQca0UHbO8eux11eRo7.rlao8NIPQqfgo59KA5TAV0u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 24, 285, DateTimeKind.Utc).AddTicks(9430), new DateTime(2025, 5, 11, 23, 9, 24, 285, DateTimeKind.Utc).AddTicks(9434), "$2a$11$NHTx.0TOITnYokqWGbPFaukKiW8y8HK12EtRSC9heb20TCvKUWdXu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 9, 24, 453, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 5, 11, 23, 9, 24, 453, DateTimeKind.Utc).AddTicks(7642), "$2a$11$6l7x44XSGKLtHOnbNRgFRuvqmAx4vPhUvwIERNk67V30aT4CiTMDS" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraInformation",
                table: "ConversationState");

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
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 5, 7, 13, 23, 26, 77, DateTimeKind.Utc).AddTicks(4546) });

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
    }
}
