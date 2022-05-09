using Microsoft.EntityFrameworkCore.Migrations;

namespace ProFit.Data.Migrations
{
    public partial class addRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Role" },
                values: new object[] { "f857ce47-ba10-485e-bb45-d9d421f51e6f", "AQAAAAEAACcQAAAAEO0XVs+gJ874loriSn2iM6EuEkTUjX7IuT0I52WYE1FLuraum8MyP9eGGWVCCErP1A==", "9c851b99-adeb-4230-ab9e-d64ae4b2b378", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "530423d1-d491-4c7b-9739-f62c7052128f", "AQAAAAEAACcQAAAAEPrQcA4PMPqzyiKp7Dik8UEQKEmenmSFQt2X8gE3rAK5oXPOTtRb5LTk2JlQaW1flw==", "79f51034-50a5-476b-b722-a44df9ee2993" });
        }
    }
}
