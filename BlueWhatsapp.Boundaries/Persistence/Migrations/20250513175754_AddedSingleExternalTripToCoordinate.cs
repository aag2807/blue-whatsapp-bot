using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedSingleExternalTripToCoordinate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[]
                {
                    "Id", 
                    "CreatedTime", 
                    "ModifiedTime",
                    "IsActive", 
                    
                    "Name",
                    "Description",
                },
                values: new object[]
                {
                    8, 
                    new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), 
                    new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), 
                    true,
                    
                    "Externo",
                    "Manejado fuera de ruta"
                }
            );
            
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[]
                {
                    "Id", "CreatedTime", "IsActive", "IsActiveForToday", "MaxCapacity", "ModifiedTime", "RouteId",
                    "TripName"
                },
                values: new object[]
                {
                    18, new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(154), true, true, 100,
                    new DateTime(2025, 5, 13, 17, 57, 50, 212, DateTimeKind.Utc).AddTicks(3782), 8, "Externo"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
