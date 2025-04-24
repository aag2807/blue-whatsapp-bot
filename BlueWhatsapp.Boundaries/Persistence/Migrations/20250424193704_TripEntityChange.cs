using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TripEntityChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove Capacity column as in your original migration
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Trips");

            // Add TripName if it doesn't exist
            migrationBuilder.AddColumn<string>(
                name: "TripName",
                table: "Trips",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            // Add the relationship with Hotels as in your original migration
            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Hotels",
                type: "INTEGER",
                nullable: true);

            // Add the relationship with Schedule
            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Schedules",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            // Create indexes
            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TripId",
                table: "Schedules",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_TripId",
                table: "Hotels",
                column: "TripId");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove foreign keys
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Trips_TripId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Trips_TripId",
                table: "Schedules");

            // Remove indexes
            migrationBuilder.DropIndex(
                name: "IX_Schedules_TripId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_TripId",
                table: "Hotels");

            // Remove columns
            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Hotels");

            // Add back columns that were removed
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Trips",
                type: "INTEGER",
                nullable: false,
                defaultValue: 30);

            // If we also added these columns in the Up method, remove them here
            // Only uncomment these if you're sure they didn't exist before
            /*
            migrationBuilder.DropColumn(
                name: "IsActiveForToday",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripName",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Trips");
            */
        }
    }
}