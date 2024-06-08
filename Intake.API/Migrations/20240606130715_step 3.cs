using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "RefRecentlyNoticed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefRecentlyNoticed", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RefRecentlyNoticed",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Cough", true },
                    { 2, "Difficulty Swallowing", true },
                    { 3, "Falls", true },
                    { 4, "Headaches", true },
                    { 5, "Nausea/Vomiting", true },
                    { 6, "Skin Changes", true },
                    { 7, "Weight Loss/Gain", true },
                    { 8, "Changed in bowel or bladder function", true },
                    { 9, "Constipation", true },
                    { 10, "Diarrhea", true },
                    { 11, "Dizziness/lightheadedness", true },
                    { 12, "Fatigue", true },
                    { 13, "Heartburn/Indigestion", true },
                    { 14, "Muscle Weakness", true },
                    { 15, "Numbness or Tingling", true },
                    { 16, "Shortness of breath", true },
                    { 17, "Weight Gain", true },
                    { 18, "Weight Loss", true },
                    { 19, "Fainting", true },
                    { 20, "Fever/Chills/Sweats", true },
                    { 21, "Difficulty maintaining balance while walking", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalIntakes");

            migrationBuilder.DropTable(
                name: "RefRecentlyNoticed");
        }
    }
}
