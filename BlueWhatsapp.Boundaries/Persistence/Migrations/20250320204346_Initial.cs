using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TravelType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MeetingPoint = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Currency = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false, defaultValue: "USD"),
                    Route = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelId = table.Column<int>(type: "INTEGER", nullable: false),
                    ScheduleId = table.Column<int>(type: "INTEGER", nullable: false),
                    RecogidaNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    HotelId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelSchedules_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelSchedules_Hotels_HotelId1",
                        column: x => x.HotelId1,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "CreatedTime", "Description", "IsActive", "ModifiedTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Punta Cana (Cap Cana)", true, null, "RUTA A" },
                    { 2, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta La Romana", true, null, "RUTA B" },
                    { 3, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Bávaro Sur", true, null, "RUTA C" },
                    { 4, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Bávaro Norte", true, null, "RUTA D" },
                    { 5, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Bávaro Central - Grupo 1", true, null, "RUTA E1" },
                    { 6, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Bávaro Central - Grupo 2", true, null, "RUTA E2" },
                    { 7, new DateTime(2025, 3, 20, 20, 43, 44, 516, DateTimeKind.Utc).AddTicks(3272), "Ruta Uvero Alto", true, null, "RUTA F" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedTime", "IsActive", "ModifiedTime", "Name", "Time" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:25", "09:25" },
                    { 2, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:30", "09:30" },
                    { 3, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:35", "09:35" },
                    { 4, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:40", "09:40" },
                    { 5, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:45", "09:45" },
                    { 6, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:50", "09:50" },
                    { 7, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:53", "09:53" },
                    { 8, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "09:55", "09:55" },
                    { 9, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:00", "10:00" },
                    { 10, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:05", "10:05" },
                    { 11, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:10", "10:10" },
                    { 12, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:20", "10:20" },
                    { 13, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:25", "10:25" },
                    { 14, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:40", "10:40" },
                    { 15, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:45", "10:45" },
                    { 16, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:55", "10:55" },
                    { 17, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:00", "11:00" },
                    { 18, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:05", "11:05" },
                    { 19, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:10", "11:10" },
                    { 20, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:15", "11:15" },
                    { 21, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:20", "11:20" },
                    { 22, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:25", "11:25" },
                    { 23, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:10", "2:10" },
                    { 24, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:15", "2:15" },
                    { 25, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:25", "2:25" },
                    { 26, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:30", "2:30" },
                    { 27, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:35", "2:35" },
                    { 28, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:40", "2:40" },
                    { 29, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:45", "2:45" },
                    { 30, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:50", "2:50" },
                    { 31, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "2:55", "2:55" },
                    { 32, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:10", "3:10" },
                    { 33, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:15", "3:15" },
                    { 34, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:20", "3:20" },
                    { 35, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:25", "3:25" },
                    { 36, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:30", "3:30" },
                    { 37, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:40", "3:40" },
                    { 38, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:45", "3:45" },
                    { 39, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:50", "3:50" },
                    { 40, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:53", "3:53" },
                    { 41, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:55", "3:55" },
                    { 42, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:00", "4:00" },
                    { 43, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:30", "3:30" },
                    { 44, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:35", "3:35" },
                    { 45, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:45", "3:45" },
                    { 46, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:50", "3:50" },
                    { 47, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "3:55", "3:55" },
                    { 48, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:00", "4:00" },
                    { 49, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:35", "4:35" },
                    { 50, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:40", "4:40" },
                    { 51, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:45", "4:45" },
                    { 52, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:50", "4:50" },
                    { 53, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "4:55", "4:55" },
                    { 54, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "5:00", "5:00" },
                    { 55, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "5:10", "5:10" },
                    { 56, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "5:15", "5:15" },
                    { 57, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "5:20", "5:20" },
                    { 58, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "5:25", "5:25" },
                    { 59, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "8:45", "8:45" },
                    { 60, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "8:50", "8:50" },
                    { 61, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "8:55", "8:55" },
                    { 62, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:00", "9:00" },
                    { 63, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:05", "9:05" },
                    { 64, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:10", "9:10" },
                    { 65, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:15", "9:15" },
                    { 66, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:20", "9:20" },
                    { 67, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "9:25", "9:25" },
                    { 68, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:40", "10:40" },
                    { 69, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:45", "10:45" },
                    { 70, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "10:55", "10:55" },
                    { 71, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:00", "11:00" },
                    { 72, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:05", "11:05" },
                    { 73, new DateTime(2025, 3, 20, 20, 43, 44, 540, DateTimeKind.Utc).AddTicks(7756), true, null, "11:10", "11:10" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CreatedTime", "Currency", "IsActive", "MeetingPoint", "ModifiedTime", "Name", "Price", "Route", "RouteId", "TravelType" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "SECRET CAP CANA", 5f, "RUTA A", 1, "VIP T2" },
                    { 2, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "HYATT ZILARA", 5f, "RUTA A", 1, "VIP T2" },
                    { 3, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "HYATT ZIVA", 5f, "RUTA A", 1, "VIP T2" },
                    { 4, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "SPORTS ILLUSTRATED", 5f, "RUTA A", 1, "VIP T2" },
                    { 5, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "TRS CAP CANA", 5f, "RUTA A", 1, "VIP T2" },
                    { 6, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "WESTIN PUNTA CANA", 0f, "RUTA B", 2, "SHUTTLE" },
                    { 7, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "FOUR POINTS", 0f, "RUTA B", 2, "SHUTTLE" },
                    { 8, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "DREAMS FLORA", 0f, "RUTA C", 3, "SHUTTLE" },
                    { 9, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "JEWEL PALM BEACH", 0f, "RUTA C", 3, "SHUTTLE" },
                    { 10, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "SUNSCAPE COCO PUNTA CANA", 0f, "RUTA C", 3, "SHUTTLE" },
                    { 11, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "SERENADE", 5f, "RUTA C", 3, "VIP T2" },
                    { 12, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "CATALONIA BAVARO", 5f, "RUTA C", 3, "VIP T2" },
                    { 13, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "CATALONIA ROYAL", 5f, "RUTA C", 3, "VIP T2" },
                    { 14, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "RIU REPUBLICA", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 15, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "BAHIA PRINCIPE (BARRERA)", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 16, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "RIU PUNTA CANA", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 17, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "RIU BAMBU", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 18, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "RIU MACAO", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 19, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "RIU BAVARO", 0f, "RUTA D", 4, "SHUTTLE" },
                    { 20, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY DE GRUPOS", null, "HARD ROCK", 10f, "RUTA D", 4, "VIP T1" },
                    { 21, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "OCCIDENTAL CARIBE", 5f, "RUTA D", 4, "VIP T2" },
                    { 22, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "ROYALTON PUNTA CANA", 5f, "RUTA D", 4, "VIP T2" },
                    { 23, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MAJESTIC COLONIAL", 5f, "RUTA D", 4, "VIP T2" },
                    { 24, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MAJESTIC ELEGANCE", 5f, "RUTA D", 4, "VIP T2" },
                    { 25, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MAJESTIC MIRAGE", 5f, "RUTA D", 4, "VIP T2" },
                    { 26, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "ROYALTON BAVARO", 5f, "RUTA D", 4, "VIP T2" },
                    { 27, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "IBEROSTAR PUNTA CANA", 5f, "RUTA D", 4, "VIP T2" },
                    { 28, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "IBEROSTAR DOMINICANA", 5f, "RUTA D", 4, "VIP T2" },
                    { 29, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "IBEROSTAR SELECTION BAVARO", 5f, "RUTA D", 4, "VIP T2" },
                    { 30, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "IBEROSTAR BAVARO", 5f, "RUTA D", 4, "VIP T2" },
                    { 31, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "VISTA SOL PUNTA CANA", 0f, "RUTA E1", 5, "SHUTTLE" },
                    { 32, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "WHALA BAVARO", 0f, "RUTA E1", 5, "SHUTTLE" },
                    { 33, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "SECRETS ROYAL BEACH", 0f, "RUTA E1", 5, "SHUTTLE" },
                    { 34, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "DREAMS ROYAL BEACH", 0f, "RUTA E1", 5, "SHUTTLE" },
                    { 35, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "DREAMS ROYAL BEACH (PREFERRED)", 0f, "RUTA E1", 5, "SHUTTLE" },
                    { 36, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "IMPRESSIVE", 5f, "RUTA E1", 5, "VIP T2" },
                    { 37, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MELIA CARIBE BEACH", 5f, "RUTA E1", 5, "VIP T2" },
                    { 38, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MELIA CARIBE TROPICAL", 5f, "RUTA E1", 5, "VIP T2" },
                    { 39, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "MELIA PUNTA CANA BEACH", 5f, "RUTA E1", 5, "VIP T2" },
                    { 40, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "PARADISUS PALMA REAL", 5f, "RUTA E1", 5, "VIP T2" },
                    { 41, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "LOPESAN COSTA BAVARO", 5f, "RUTA E1", 5, "VIP T2" },
                    { 42, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "BARCELO BAVARO BEACH", 5f, "RUTA E1", 5, "VIP T2" },
                    { 43, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "BARCELO BAVARO PALACE", 5f, "RUTA E1", 5, "VIP T2" },
                    { 44, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "PUNTA CANA PRINCESS", 5f, "RUTA E2", 6, "VIP T2" },
                    { 45, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "VIK ARENA BLANCA", 5f, "RUTA E2", 6, "VIP T2" },
                    { 46, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "OCEAN BLUE AND SAND", 5f, "RUTA E2", 6, "VIP T2" },
                    { 47, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "CARIBE DELUXE PRINCESS", 5f, "RUTA E2", 6, "VIP T2" },
                    { 48, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "TROPICAL DELUXE PRINCESS", 5f, "RUTA E2", 6, "VIP T2" },
                    { 49, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "BAVARO PRINCESS", 5f, "RUTA E2", 6, "VIP T2" },
                    { 50, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "OCCIDENTAL PUNTA CANA", 5f, "RUTA E2", 6, "VIP T2" },
                    { 51, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "GRAND BAVARO PRINCESS", 5f, "RUTA E2", 6, "VIP T2" },
                    { 52, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "GRAND PALLADIUM BAVARO", 5f, "RUTA E2", 6, "VIP T2" },
                    { 53, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "GRAND PALLADIUM PALACE", 5f, "RUTA E2", 6, "VIP T2" },
                    { 54, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "GRAND PALLADIUM PUNTA CANA", 5f, "RUTA E2", 6, "VIP T2" },
                    { 55, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "GRAND PALLADIUM TRS TURQUESA", 5f, "RUTA E2", 6, "VIP T2" },
                    { 56, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "ZOETRY AGUA", 10f, "RUTA F", 7, "VIP T1" },
                    { 57, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "BARRERA", null, "EXCELLENCE PUNTA CANA", 10f, "RUTA F", 7, "VIP T1" },
                    { 58, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "SIRENIS", 10f, "RUTA F", 7, "VIP T1" },
                    { 59, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "SECRETS TIDES PUNTA CANA", 10f, "RUTA F", 7, "VIP T1" },
                    { 60, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "BREATHLESS PUNTA CANA", 10f, "RUTA F", 7, "VIP T1" },
                    { 61, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "DREAMS ONYX PUNTA CANA", 10f, "RUTA F", 7, "VIP T1" },
                    { 62, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "JEWEL PUNTA CANA", 10f, "RUTA F", 7, "VIP T1" },
                    { 63, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "ROYALTON CHIC", 10f, "RUTA F", 7, "VIP T1" },
                    { 64, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "NICKELODEON", 10f, "RUTA F", 7, "VIP T1" },
                    { 65, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "OCEAN EL FARO", 10f, "RUTA F", 7, "VIP T1" },
                    { 66, new DateTime(2025, 3, 20, 20, 43, 44, 480, DateTimeKind.Utc).AddTicks(3565), "USD", true, "LOBBY", null, "DREAMS MACAO", 10f, "RUTA F", 7, "VIP T1" }
                });

            migrationBuilder.InsertData(
                table: "HotelSchedules",
                columns: new[] { "Id", "CreatedTime", "HotelId", "HotelId1", "IsActive", "ModifiedTime", "RecogidaNumber", "ScheduleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 1, null, true, null, 1, 1 },
                    { 2, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 1, null, true, null, 2, 27 },
                    { 3, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 2, null, true, null, 1, 2 },
                    { 4, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 2, null, true, null, 2, 28 },
                    { 5, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 3, null, true, null, 1, 3 },
                    { 6, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 3, null, true, null, 2, 29 },
                    { 7, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 4, null, true, null, 1, 4 },
                    { 8, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 4, null, true, null, 2, 30 },
                    { 9, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 5, null, true, null, 1, 5 },
                    { 10, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 5, null, true, null, 2, 31 },
                    { 11, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 6, null, true, null, 1, 12 },
                    { 12, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 6, null, true, null, 2, 45 },
                    { 13, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 7, null, true, null, 1, 13 },
                    { 14, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 7, null, true, null, 2, 45 },
                    { 15, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 8, null, true, null, 1, 4 },
                    { 16, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 8, null, true, null, 2, 37 },
                    { 17, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 9, null, true, null, 1, 5 },
                    { 18, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 9, null, true, null, 2, 38 },
                    { 19, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 10, null, true, null, 1, 6 },
                    { 20, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 10, null, true, null, 2, 46 },
                    { 21, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 11, null, true, null, 1, 7 },
                    { 22, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 11, null, true, null, 2, 40 },
                    { 23, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 12, null, true, null, 1, 8 },
                    { 24, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 12, null, true, null, 2, 41 },
                    { 25, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 13, null, true, null, 1, 9 },
                    { 26, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 13, null, true, null, 2, 42 },
                    { 27, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 14, null, true, null, 1, 10 },
                    { 28, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 14, null, true, null, 2, 68 },
                    { 29, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 14, null, true, null, 3, 43 },
                    { 30, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 15, null, true, null, 1, 11 },
                    { 31, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 15, null, true, null, 2, 69 },
                    { 32, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 15, null, true, null, 3, 44 },
                    { 33, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 16, null, true, null, 1, 4 },
                    { 34, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 16, null, true, null, 2, 70 },
                    { 35, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 16, null, true, null, 3, 37 },
                    { 36, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 17, null, true, null, 1, 1 },
                    { 37, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 17, null, true, null, 2, 71 },
                    { 38, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 17, null, true, null, 3, 46 },
                    { 39, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 18, null, true, null, 1, 2 },
                    { 40, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 18, null, true, null, 2, 72 },
                    { 41, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 18, null, true, null, 3, 47 },
                    { 42, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 19, null, true, null, 1, 3 },
                    { 43, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 19, null, true, null, 2, 73 },
                    { 44, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 19, null, true, null, 3, 42 },
                    { 45, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 20, null, true, null, 1, 15 },
                    { 46, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 20, null, true, null, 4, 50 },
                    { 47, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 21, null, true, null, 1, 16 },
                    { 48, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 21, null, true, null, 2, 29 },
                    { 49, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 21, null, true, null, 4, 51 },
                    { 50, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 22, null, true, null, 1, 16 },
                    { 51, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 22, null, true, null, 2, 29 },
                    { 52, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 22, null, true, null, 4, 51 },
                    { 53, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 23, null, true, null, 1, 17 },
                    { 54, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 23, null, true, null, 2, 30 },
                    { 55, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 23, null, true, null, 4, 52 },
                    { 56, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 24, null, true, null, 1, 17 },
                    { 57, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 24, null, true, null, 2, 30 },
                    { 58, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 24, null, true, null, 4, 52 },
                    { 59, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 25, null, true, null, 1, 17 },
                    { 60, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 25, null, true, null, 2, 30 },
                    { 61, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 25, null, true, null, 4, 52 },
                    { 62, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 26, null, true, null, 1, 17 },
                    { 63, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 26, null, true, null, 2, 30 },
                    { 64, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 26, null, true, null, 4, 52 },
                    { 65, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 27, null, true, null, 1, 19 },
                    { 66, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 27, null, true, null, 2, 33 },
                    { 67, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 27, null, true, null, 4, 55 },
                    { 68, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 28, null, true, null, 1, 20 },
                    { 69, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 28, null, true, null, 2, 34 },
                    { 70, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 28, null, true, null, 4, 56 },
                    { 71, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 29, null, true, null, 1, 21 },
                    { 72, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 29, null, true, null, 2, 35 },
                    { 73, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 29, null, true, null, 4, 57 },
                    { 74, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 30, null, true, null, 1, 22 },
                    { 75, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 30, null, true, null, 2, 36 },
                    { 76, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 30, null, true, null, 4, 58 },
                    { 77, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 31, null, true, null, 1, 14 },
                    { 78, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 31, null, true, null, 2, 23 },
                    { 79, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 32, null, true, null, 1, 15 },
                    { 80, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 32, null, true, null, 2, 24 },
                    { 81, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 33, null, true, null, 1, 16 },
                    { 82, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 33, null, true, null, 2, 25 },
                    { 83, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 34, null, true, null, 1, 17 },
                    { 84, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 34, null, true, null, 2, 26 },
                    { 85, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 35, null, true, null, 1, 18 },
                    { 86, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 35, null, true, null, 2, 27 },
                    { 87, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 36, null, true, null, 1, 17 },
                    { 88, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 36, null, true, null, 4, 50 },
                    { 89, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 37, null, true, null, 1, 19 },
                    { 90, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 37, null, true, null, 4, 51 },
                    { 91, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 38, null, true, null, 1, 19 },
                    { 92, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 38, null, true, null, 4, 51 },
                    { 93, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 39, null, true, null, 1, 19 },
                    { 94, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 39, null, true, null, 4, 51 },
                    { 95, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 40, null, true, null, 1, 19 },
                    { 96, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 40, null, true, null, 4, 51 },
                    { 97, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 41, null, true, null, 1, 19 },
                    { 98, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 41, null, true, null, 4, 51 },
                    { 99, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 42, null, true, null, 1, 21 },
                    { 100, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 42, null, true, null, 4, 54 },
                    { 101, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 43, null, true, null, 1, 21 },
                    { 102, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 43, null, true, null, 4, 54 },
                    { 103, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 44, null, true, null, 1, 18 },
                    { 104, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 44, null, true, null, 2, 32 },
                    { 105, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 44, null, true, null, 4, 51 },
                    { 106, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 45, null, true, null, 1, 18 },
                    { 107, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 45, null, true, null, 2, 32 },
                    { 108, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 45, null, true, null, 4, 51 },
                    { 109, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 46, null, true, null, 1, 18 },
                    { 110, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 46, null, true, null, 2, 32 },
                    { 111, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 46, null, true, null, 4, 51 },
                    { 112, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 47, null, true, null, 1, 19 },
                    { 113, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 47, null, true, null, 2, 34 },
                    { 114, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 47, null, true, null, 4, 52 },
                    { 115, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 48, null, true, null, 1, 19 },
                    { 116, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 48, null, true, null, 2, 34 },
                    { 117, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 48, null, true, null, 4, 52 },
                    { 118, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 49, null, true, null, 1, 19 },
                    { 119, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 49, null, true, null, 2, 34 },
                    { 120, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 49, null, true, null, 4, 52 },
                    { 121, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 50, null, true, null, 1, 19 },
                    { 122, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 50, null, true, null, 2, 34 },
                    { 123, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 50, null, true, null, 4, 52 },
                    { 124, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 51, null, true, null, 1, 20 },
                    { 125, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 51, null, true, null, 2, 35 },
                    { 126, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 51, null, true, null, 4, 54 },
                    { 127, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 52, null, true, null, 1, 20 },
                    { 128, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 52, null, true, null, 2, 35 },
                    { 129, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 52, null, true, null, 4, 54 },
                    { 130, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 53, null, true, null, 1, 20 },
                    { 131, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 53, null, true, null, 2, 35 },
                    { 132, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 53, null, true, null, 4, 54 },
                    { 133, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 54, null, true, null, 1, 20 },
                    { 134, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 54, null, true, null, 2, 35 },
                    { 135, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 54, null, true, null, 4, 54 },
                    { 136, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 55, null, true, null, 1, 20 },
                    { 137, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 55, null, true, null, 2, 35 },
                    { 138, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 55, null, true, null, 4, 54 },
                    { 139, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 56, null, true, null, 1, 59 },
                    { 140, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 56, null, true, null, 2, 34 },
                    { 141, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 57, null, true, null, 1, 60 },
                    { 142, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 57, null, true, null, 2, 34 },
                    { 143, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 58, null, true, null, 1, 61 },
                    { 144, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 58, null, true, null, 2, 35 },
                    { 145, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 59, null, true, null, 1, 61 },
                    { 146, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 59, null, true, null, 2, 36 },
                    { 147, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 60, null, true, null, 1, 62 },
                    { 148, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 60, null, true, null, 2, 37 },
                    { 149, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 61, null, true, null, 1, 63 },
                    { 150, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 61, null, true, null, 2, 38 },
                    { 151, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 62, null, true, null, 1, 64 },
                    { 152, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 62, null, true, null, 2, 39 },
                    { 153, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 63, null, true, null, 1, 65 },
                    { 154, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 63, null, true, null, 2, 39 },
                    { 155, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 64, null, true, null, 1, 65 },
                    { 156, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 64, null, true, null, 2, 39 },
                    { 157, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 65, null, true, null, 1, 66 },
                    { 158, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 65, null, true, null, 2, 40 },
                    { 159, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 66, null, true, null, 1, 67 },
                    { 160, new DateTime(2025, 3, 20, 20, 43, 44, 511, DateTimeKind.Utc).AddTicks(2933), 66, null, true, null, 2, 41 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_RouteId",
                table: "Hotels",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelSchedules_HotelId_ScheduleId_RecogidaNumber",
                table: "HotelSchedules",
                columns: new[] { "HotelId", "ScheduleId", "RecogidaNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelSchedules_HotelId1",
                table: "HotelSchedules",
                column: "HotelId1");

            migrationBuilder.CreateIndex(
                name: "IX_HotelSchedules_ScheduleId",
                table: "HotelSchedules",
                column: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelSchedules");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
