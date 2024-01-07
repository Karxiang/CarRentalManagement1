using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatecustomernvehicledb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c8a843-5b96-42cf-9046-6c3a4ae6de9f", "AQAAAAIAAYagAAAAEMja+z6Wa1EaPrm2iMC8itb7eCx5VwXDj6WjSFu8IVnff225W2+h4B6dXor0R4OYIA==", "601970f4-9e38-4c4e-8062-9e8209728799" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8261), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 1, 3, 11, 57, 41, 187, DateTimeKind.Local).AddTicks(8471) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "907d045a-63d9-43b9-90a0-fd8decace1da", "AQAAAAIAAYagAAAAECOWoIuNRsvVmOmLB1DxvkfrxkkTe2sDfP9kK6XTleyvU/W4lAlRYox5EqoEG+BJ7A==", "977a50bf-049e-446d-b457-dc20a43ad0ba" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2072), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2406), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2607), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 1, 3, 11, 5, 1, 181, DateTimeKind.Local).AddTicks(2610) });
        }
    }
}
