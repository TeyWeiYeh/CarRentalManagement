using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstNameAndLastNameFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7357bf4-5910-46aa-9ecc-ee41baf882e5", "AQAAAAIAAYagAAAAEGk5CiWudw2jAjH725ijZQHBXMB4QmSeQnieURTmT3juQZuDmU8FD1RGucEYE3SNog==", "ad52c8a8-bb36-426a-b168-f6079447aea4" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 390, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 1, 4, 11, 47, 13, 390, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 390, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 1, 4, 11, 47, 13, 390, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(425), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 1, 4, 11, 47, 13, 391, DateTimeKind.Local).AddTicks(427) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f5bd59-b32c-4072-8054-9a9deda36bbd", "AQAAAAIAAYagAAAAED3eZ5QMYPZUNQf4EIlNR5HDgXjqRTSe61p0ZBxWWc0l2XG1PE9Y/BBTNlo44D21pQ==", "53a70c74-9f72-4af7-9835-d78d8952a1ef" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2850), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 1, 2, 15, 33, 0, 348, DateTimeKind.Local).AddTicks(3031) });
        }
    }
}
