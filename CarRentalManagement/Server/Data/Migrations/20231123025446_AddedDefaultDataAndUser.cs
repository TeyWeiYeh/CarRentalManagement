using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e39e07d8-e70a-436b-a3ed-ec77bdd4e7e7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHvYbNH9y1vbm9r7nG2PiGtx+AWK+sPm8PDbDWWv4cAuQBJu74PD0jvC49rOlOiOoA==", null, false, "818c21dd-300a-4e0c-806c-adba1d02195d", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 10, 54, 46, 128, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 11, 23, 10, 54, 46, 128, DateTimeKind.Local).AddTicks(9265), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 10, 54, 46, 128, DateTimeKind.Local).AddTicks(9271), new DateTime(2023, 11, 23, 10, 54, 46, 128, DateTimeKind.Local).AddTicks(9272), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(9), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(11), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(16), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(420), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(425), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(429), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 11, 23, 10, 54, 46, 129, DateTimeKind.Local).AddTicks(432), "RAV4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
