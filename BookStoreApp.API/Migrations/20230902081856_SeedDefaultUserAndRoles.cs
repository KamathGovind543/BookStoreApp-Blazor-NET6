using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bec6e49-0dbe-4cd6-b0b0-5e556d2d3d28", "6ced4c92-dafe-473b-a492-ab8ab9a2ca74", "user", "USER" },
                    { "987f9fef-9ed9-4f30-8b4d-f295cc4f3ea6", "5f2bc56e-c127-4a17-bd2f-9d6098b71761", "admin", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24d20d4c-27de-44d7-b750-d2873918339c", 0, "64f855d7-53a2-4c67-9173-acffc33574a0", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEJNN36g+fieOfWG295duedRT8IukQ0pFBNLWkm0/w9KBR//Jum4fUDgO0jRA5WNZnQ==", null, false, "2a703c3f-c5b5-4762-affc-4af9a58f5123", false, "user@bookstore.com" },
                    { "841db919-7edc-4172-ad0b-c24de556ab3f", 0, "0fc23290-6b14-4520-8d64-5e12be1e5519", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEEoXBkqCFoaBDv9bUhHnK+fIUy7nl7SejnTgU8m6Y+QML/L9fNXA7g8o/TYXzG1shA==", null, false, "22e77898-9731-4caa-9d2a-41a68cfb0993", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3bec6e49-0dbe-4cd6-b0b0-5e556d2d3d28", "24d20d4c-27de-44d7-b750-d2873918339c" },
                    { "987f9fef-9ed9-4f30-8b4d-f295cc4f3ea6", "841db919-7edc-4172-ad0b-c24de556ab3f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3bec6e49-0dbe-4cd6-b0b0-5e556d2d3d28", "24d20d4c-27de-44d7-b750-d2873918339c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "987f9fef-9ed9-4f30-8b4d-f295cc4f3ea6", "841db919-7edc-4172-ad0b-c24de556ab3f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bec6e49-0dbe-4cd6-b0b0-5e556d2d3d28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "987f9fef-9ed9-4f30-8b4d-f295cc4f3ea6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d20d4c-27de-44d7-b750-d2873918339c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "841db919-7edc-4172-ad0b-c24de556ab3f");
        }
    }
}
