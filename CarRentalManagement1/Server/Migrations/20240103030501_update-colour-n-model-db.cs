using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatecolournmodeldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2043211a-c87d-4d5f-9c3b-fe323da49e8d", "AQAAAAIAAYagAAAAEPhX/uiBJXJHEMb7hFjsyCRa3Vtqum1nDsqUwPbC1x2+JUl6++xXq3Ewi41GGTkaRw==", "dbc0692d-8dfb-4233-a402-35599acc97e2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4202), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 1, 2, 15, 10, 58, 136, DateTimeKind.Local).AddTicks(4936) });
        }
    }
}
