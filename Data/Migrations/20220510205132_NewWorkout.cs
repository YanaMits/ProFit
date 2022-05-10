using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProFit.Data.Migrations
{
    public partial class NewWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TrainerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutParticipants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkoutParticipants_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc63577-96d3-4dbd-98da-12685f90e3e1", "AQAAAAEAACcQAAAAEBj41tO4H5lc8u6O4BYr6h9EHajwWJSCIbDsDLErcSnKYA9YAVpGnY55jHkf2YbGng==", "0e0a00b4-cf73-450a-a6f8-3d4058abc4bd" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutParticipants_UserId",
                table: "WorkoutParticipants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutParticipants_WorkoutId",
                table: "WorkoutParticipants",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_TrainerId",
                table: "Workouts",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutParticipants");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f857ce47-ba10-485e-bb45-d9d421f51e6f", "AQAAAAEAACcQAAAAEO0XVs+gJ874loriSn2iM6EuEkTUjX7IuT0I52WYE1FLuraum8MyP9eGGWVCCErP1A==", "9c851b99-adeb-4230-ab9e-d64ae4b2b378" });
        }
    }
}
