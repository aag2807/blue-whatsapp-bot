using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedTripData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var currentTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA A", "Cap Cana", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA B", "Punta Cana", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA C", "Cabeza de Toro", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA D", "Bávaro (Arena Gorda)", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA E1", "Bávaro (Cortecito)", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA E2", "Bávaro (White Sands)", true });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Description", "IsActive" },
                values: new object[] { "RUTA F", "Uvero Alto", true });

            // Seed Trip data
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 1, "Ruta A (Recogida 1)", true, 1, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 2, "Ruta A (Recogida 2)", true, 1, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 3, "Ruta B (Recogida 1)", true, 2, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 4, "Ruta B (Recogida 2)", true, 2, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 5, "Ruta C (Recogida 1)", true, 3, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 6, "Ruta C (Recogida 2)", true, 3, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 7, "Ruta D (Recogida 1)", true, 4, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 8, "Ruta D (Recogida 2)", true, 4, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 9, "Ruta D (Recogida 3)", true, 4, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 10, "Ruta E1 (Recogida 1)", true, 5, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 11, "Ruta E1 (Recogida 2)", true, 5, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 12, "Ruta E1 (Recogida 3)", true, 5, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 13, "Ruta E2 (Recogida 1)", true, 6, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 14, "Ruta E2 (Recogida 2)", true, 6, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 15, "Ruta E2 (Recogida 3)", true, 6, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 16, "Ruta F (Recogida 1)", true, 7, true, currentTime });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "TripName", "IsActive", "RouteId", "IsActiveForToday", "CreatedTime" },
                values: new object[] { 17, "Ruta F (Recogida 2)", true, 7, true, currentTime });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove all seeded Trip data
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}