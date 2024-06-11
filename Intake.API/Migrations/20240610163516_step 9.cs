using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FeelingDown",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubmitted",
                table: "MedicalIntakes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LittleInterest",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherProblems",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TherapyGoals",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "UnsafeAtHome",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WantHelp",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RefFamilyDiagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefFamilyDiagnoses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RefFamilyDiagnoses",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Blood Clots", "Active" },
                    { 2, "Heart Problems", "Active" },
                    { 3, "Stroke", "Active" },
                    { 4, "Cancer", "Active" },
                    { 5, "Diabetes", "Active" },
                    { 6, "High Blood Pressure", "Active" },
                    { 7, "Thyroid Problems", "Active" },
                    { 8, "Depression", "Active" },
                    { 9, "Tuberculosis", "Active" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefFamilyDiagnoses");

            migrationBuilder.DropColumn(
                name: "FeelingDown",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "IsSubmitted",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "LittleInterest",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "OtherProblems",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "TherapyGoals",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "UnsafeAtHome",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "WantHelp",
                table: "MedicalIntakes");
        }
    }
}
