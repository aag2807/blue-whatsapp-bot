using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRelationShipsForTripsHotelsAndSchedules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Trips_TripId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Trips_TripId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_TripId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_TripId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Hotels");

            migrationBuilder.CreateTable(
                name: "TripSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TripId = table.Column<int>(type: "INTEGER", nullable: false),
                    ScheduleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripSchedules_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 516, DateTimeKind.Utc).AddTicks(9932), new DateTime(2025, 4, 24, 21, 59, 39, 516, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 4, 24, 21, 59, 39, 526, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 4, 24, 21, 59, 39, 523, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 4, 24, 21, 59, 39, 528, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 24, 21, 59, 39, 530, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(4482), new DateTime(2025, 4, 24, 21, 59, 39, 535, DateTimeKind.Utc).AddTicks(4485), "$2a$11$36.oIxnnZNbWtjqk8HsRAuODhZiGoaUlLpSFmS/WM6k7KHoeafMAC" });

            migrationBuilder.CreateIndex(
                name: "IX_TripSchedules_ScheduleId",
                table: "TripSchedules",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_TripSchedules_TripId",
                table: "TripSchedules",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripSchedules");

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Schedules",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Hotels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 38, DateTimeKind.Utc).AddTicks(3395), new DateTime(2025, 4, 24, 20, 34, 18, 38, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 4, 24, 20, 34, 18, 52, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8790), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8813), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8819), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8824), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8829), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8834), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8838), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8843), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8847), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8852), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8871), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8876), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8881), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8886), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8891), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8896), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8902), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8907), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8911), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8916), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8920), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8925), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8929), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8933), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8939), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8943), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8948), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8952), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8969), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8974), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8981), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8986), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8990), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9053), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9058), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9062), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9067), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9073), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9078), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9082), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9086), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9091), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9096), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9100), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9104), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9109), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9113), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9117), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9122), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9127), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9130), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9134), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9143), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9147), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9151), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9156), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9160), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9164), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9168), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9173), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9177), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9182), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9186), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9191), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9195), null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 4, 24, 20, 34, 18, 46, DateTimeKind.Utc).AddTicks(9199), null });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 4, 24, 20, 34, 18, 55, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1835), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1841), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1844), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1846), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1848), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1850), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1853), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1855), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1857), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1858), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1860), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1862), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1864), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1866), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1868), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1870), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1872), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1874), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1876), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1878), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1880), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1882), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1884), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1886), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1888), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1890), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1892), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1894), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1895), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1897), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1899), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1901), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1903), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1906), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1908), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1910), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1912), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1914), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1916), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1918), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1919), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1921), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1923), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1925), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1927), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1929), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1931), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1933), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1935), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1937), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1938), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1940), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1942), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1944), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1946), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1948), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1950), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1952), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1954), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1956), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1958), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1960), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1962), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1963), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1965), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1967), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1969), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1971), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1973), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1975), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1977), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(2008), null });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime", "TripId" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(1825), new DateTime(2025, 4, 24, 20, 34, 18, 58, DateTimeKind.Utc).AddTicks(2010), null });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 4, 24, 20, 34, 18, 59, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 4, 24, 20, 34, 18, 60, DateTimeKind.Utc).AddTicks(1622), new DateTime(2025, 4, 24, 20, 34, 18, 60, DateTimeKind.Utc).AddTicks(1623), "$2a$11$3WkF2PJ4fWMmAVhi/4xWqeppxjBdmtExVOvHvL2HZmsXbpEt2sl6m" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TripId",
                table: "Schedules",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_TripId",
                table: "Hotels",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Trips_TripId",
                table: "Hotels",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Trips_TripId",
                table: "Schedules",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id");
        }
    }
}
