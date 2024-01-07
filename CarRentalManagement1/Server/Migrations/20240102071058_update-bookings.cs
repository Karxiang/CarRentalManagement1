using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatebookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ec2565-f894-48fb-83d4-983722bf415e", "AQAAAAIAAYagAAAAEI2UoMSK9oHnMbrEfNyx9B9mPUSroeWWaKEtr7HzumUAF6qqRvHPFdvv/+CXP6TDdA==", "4fd6e5fc-0790-4aeb-8a51-96d54cee27bc" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6117), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6135), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 1, 2, 15, 4, 4, 528, DateTimeKind.Local).AddTicks(6795) });
        }
    }
}
