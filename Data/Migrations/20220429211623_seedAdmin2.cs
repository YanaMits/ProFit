using Microsoft.EntityFrameworkCore.Migrations;

namespace ProFit.Data.Migrations
{
    public partial class seedAdmin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a0031e-2b8c-455e-a699-9981bbc5f931", "YANA.PRESSA@GMAIL.COM", "AQAAAAEAACcQAAAAEL6rCjf5oqSOT1MtQSj7KioUNpKQ2kyIEiC6Zm352MaW5PFWvA3fdVIJc/nT+ajYGQ==", "58d380ad-ba40-4845-95da-4156e41ae4bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55f9d9b-5cda-476e-94be-2dd560cbb982", null, "AQAAAAEAACcQAAAAENPAXcVY9jy9tJOLYjkt9Xdnu7xPDcLBYL3lEEsCGu2ylAbiTCMaq3iLWv5fnviPFw==", "2f05896a-95e3-4fb2-b959-dc8aa8bc5560" });
        }
    }
}
