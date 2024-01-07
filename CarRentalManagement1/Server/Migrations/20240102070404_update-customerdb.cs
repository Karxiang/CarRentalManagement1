using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatecustomerdb : Migration
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
                values: new object[] { "a72ad8df-059a-4369-a909-5c45b957ddba", "AQAAAAIAAYagAAAAEJtFb0OstbcEhoK0m0DcuGPH98zR2CXVgrLENxExe4Ig8hHdsbXcnqZLvdrobZ8rig==", "fe7474d9-189a-44c6-82e7-b4a2e3a25a3f" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 1, 2, 14, 26, 37, 832, DateTimeKind.Local).AddTicks(8609) });
        }
    }
}
