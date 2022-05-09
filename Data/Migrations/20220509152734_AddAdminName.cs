using Microsoft.EntityFrameworkCore.Migrations;

namespace ProFit.Data.Migrations
{
    public partial class AddAdminName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Name", "Phone" },
                values: new object[] { "530423d1-d491-4c7b-9739-f62c7052128f", "AQAAAAEAACcQAAAAEPrQcA4PMPqzyiKp7Dik8UEQKEmenmSFQt2X8gE3rAK5oXPOTtRb5LTk2JlQaW1flw==", "79f51034-50a5-476b-b722-a44df9ee2993", "Yana_admin", "0765689464" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Name", "Phone" },
                values: new object[] { "73a0031e-2b8c-455e-a699-9981bbc5f931", "AQAAAAEAACcQAAAAEL6rCjf5oqSOT1MtQSj7KioUNpKQ2kyIEiC6Zm352MaW5PFWvA3fdVIJc/nT+ajYGQ==", "58d380ad-ba40-4845-95da-4156e41ae4bf", null, null });
        }
    }
}
