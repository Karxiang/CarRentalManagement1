using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Server.Data.Migrations
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8487be6e-1619-49b8-a079-9848927f37ff", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO88Psp+rBEwB4RedFJDkzV4R6JoWxIBbYIJLq6aFCCM8MjPfbL5FonwElV/yKirDg==", null, false, "3e9c3ab7-109c-4fc8-8108-9d0257b94aff", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8170), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8174), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8781), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(8784), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9155), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9158), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9161), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 11, 22, 11, 40, 48, 532, DateTimeKind.Local).AddTicks(9163), "Rav4", "System" }
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
