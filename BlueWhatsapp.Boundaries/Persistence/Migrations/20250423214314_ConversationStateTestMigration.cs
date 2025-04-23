using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWhatsapp.Boundaries.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ConversationStateTestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ConversationState_UserNumber",
                table: "ConversationState");

            // Existing string property changes
            migrationBuilder.AlterColumn<string>(
                name: "ZoneId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "UserNumber",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ScheduleId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDate",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "HotelId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60);

            // Add configurations for the other properties that weren't modified
            migrationBuilder.AlterColumn<int>(
                name: "CurrentStep",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Flow",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
                
            migrationBuilder.AlterColumn<bool>(
                name: "IsComplete",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
                
            migrationBuilder.AlterColumn<bool>(
                name: "IsAdminOverridden",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
                
            migrationBuilder.AlterColumn<int>(
                name: "Adults",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
                
            migrationBuilder.AlterColumn<int>(
                name: "Children",
                table: "ConversationState",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 21, 43, 12, 996, DateTimeKind.Utc).AddTicks(3371), new DateTime(2025, 4, 23, 21, 43, 12, 996, DateTimeKind.Utc).AddTicks(3373) });
            }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZoneId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserNumber",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScheduleId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDate",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HotelId",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ConversationState",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ConversationState",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 242, DateTimeKind.Utc).AddTicks(3305), new DateTime(2025, 4, 23, 14, 31, 15, 242, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "HotelSchedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 4, 23, 14, 31, 15, 251, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 4, 23, 14, 31, 15, 248, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 23, 14, 31, 15, 254, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 23, 14, 31, 15, 258, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3838), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3857), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3859), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3861), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3863), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3865), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3867), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3869), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3871), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3873), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3874), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3876), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3878), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3880), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "Password" },
                values: new object[] { new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(9629), new DateTime(2025, 4, 23, 14, 31, 15, 261, DateTimeKind.Utc).AddTicks(9633), "$2a$11$snZiO.4VpTeBpoIXEuZ/OONMGQQw1IbwC89LGDjuhwviofjWbxWvq" });

            migrationBuilder.CreateIndex(
                name: "IX_ConversationState_UserNumber",
                table: "ConversationState",
                column: "UserNumber");
        }
    }
}
