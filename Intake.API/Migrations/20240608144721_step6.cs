using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AggravatingFactors",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestPainLevel",
                table: "MedicalIntakes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestSymptoms",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentPainLevel",
                table: "MedicalIntakes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EasingFactors",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SleepIssues",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorstPainLevel",
                table: "MedicalIntakes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorstSymptoms",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AggravatingFactors",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "BestPainLevel",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "BestSymptoms",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "CurrentPainLevel",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "EasingFactors",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SleepIssues",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "WorstPainLevel",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "WorstSymptoms",
                table: "MedicalIntakes");
        }
    }
}
