using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSomeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelSchedules_Hotels_HotelId1",
                table: "HotelSchedules");

            migrationBuilder.DropTable(
                name: "TripSchedules");

            migrationBuilder.DropIndex(
                name: "IX_HotelSchedules_HotelId1",
                table: "HotelSchedules");

            migrationBuilder.DropColumn(
                name: "HotelId1",
                table: "HotelSchedules");

            // Update Schedule data
            var currentTime = DateTime.UtcNow;
            
            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:25 AM", "09:25 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:30 AM", "09:30 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:35 AM", "09:35 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:40 AM", "09:40 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:45 AM", "09:45 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:50 AM", "09:50 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:53 AM", "09:53 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Time" },
                values: new object[] { "09:55 AM", "09:55 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:00 AM", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:05 AM", "10:05 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:10 AM", "10:10 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:20 AM", "10:20 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:25 AM", "10:25 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:40 AM", "10:40 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:45 AM", "10:45 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:55 AM", "10:55 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:00 AM", "11:00 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:05 AM", "11:05 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:10 AM", "11:10 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:15 AM", "11:15 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:20 AM", "11:20 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:25 AM", "11:25 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:10 PM", "2:10 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:15 PM", "2:15 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:25 PM", "2:25 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:30 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:35 PM", "2:35 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:40 PM", "2:40 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:45 PM", "2:45 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:50 PM", "2:50 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Time" },
                values: new object[] { "2:55 PM", "2:55 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:10 PM", "3:10 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:15 PM", "3:15 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:20 PM", "3:20 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:25 PM", "3:25 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:30 PM", "3:30 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:40 PM", "3:40 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:45 PM", "3:45 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:50 PM", "3:50 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:53 PM", "3:53 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:55 PM", "3:55 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:00 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:30 PM", "3:30 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:35 PM", "3:35 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:45 PM", "3:45 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:50 PM", "3:50 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Time" },
                values: new object[] { "3:55 PM", "3:55 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:00 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:35 PM", "4:35 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:40 PM", "4:40 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:45 PM", "4:45 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:50 PM", "4:50 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "Time" },
                values: new object[] { "4:55 PM", "4:55 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "Time" },
                values: new object[] { "5:00 PM", "5:00 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Time" },
                values: new object[] { "5:10 PM", "5:10 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "Time" },
                values: new object[] { "5:15 PM", "5:15 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "Time" },
                values: new object[] { "5:20 PM", "5:20 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "Time" },
                values: new object[] { "5:25 PM", "5:25 PM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "Time" },
                values: new object[] { "8:45 AM", "8:45 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "Time" },
                values: new object[] { "8:50 AM", "8:50 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "Time" },
                values: new object[] { "8:55 AM", "8:55 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:00 AM", "9:00 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:05 AM", "9:05 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:10 AM", "9:10 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:15 AM", "9:15 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:20 AM", "9:20 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "Time" },
                values: new object[] { "9:25 AM", "9:25 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:40 AM", "10:40 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:45 AM", "10:45 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "Time" },
                values: new object[] { "10:55 AM", "10:55 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:00 AM", "11:00 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:05 AM", "11:05 AM" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "Time" },
                values: new object[] { "11:10 AM", "11:10 AM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelId1",
                table: "HotelSchedules",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TripSchedules",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "INTEGER", nullable: false),
                    ScheduleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    ModifiedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripSchedules", x => new { x.TripId, x.ScheduleId });
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
        }
    }
}
