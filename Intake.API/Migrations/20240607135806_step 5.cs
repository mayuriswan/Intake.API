using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HadProblemBefore",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalActivity",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProblemBeforeWhen",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialTests",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SymptomCause",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SymptomStartDate",
                table: "MedicalIntakes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SymptomStartEst",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SymptomStatus",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatmentBefore",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatmentReceived",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HadProblemBefore",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "PhysicalActivity",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "ProblemBeforeWhen",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SpecialTests",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SymptomCause",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SymptomStartDate",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SymptomStartEst",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SymptomStatus",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "TreatmentBefore",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "TreatmentReceived",
                table: "MedicalIntakes");
        }
    }
}
