using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class removeimageentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "679639b4-b3f3-4c69-9e1f-aa95edd7271a", "AQAAAAIAAYagAAAAEOgn0Re/XgprpwYyNzLS0DPgR/mo495Ng4x/9Zz5VnvDlq/T/lGflNhPBu/0YHmUuQ==", "34b842bf-435a-4a83-8dcd-23ea659f481c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(2226), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(2243), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3236), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3450), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3454), new DateTime(2024, 1, 23, 12, 17, 7, 952, DateTimeKind.Local).AddTicks(3454) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a70fd255-a6d2-42ae-830f-e670c3cf203e", "AQAAAAIAAYagAAAAEIhxZYpU+Ko4gVZG5WuVZXTWDVSs0ClXgIg46RnlMgPbpIsjiaDClW0lCxVZ3P/s7Q==", "a8fb7e91-4fd5-4f07-b148-251217669e29" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2053), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2058), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2068), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2071), new DateTime(2024, 1, 21, 22, 2, 21, 461, DateTimeKind.Local).AddTicks(2072) });
        }
    }
}
