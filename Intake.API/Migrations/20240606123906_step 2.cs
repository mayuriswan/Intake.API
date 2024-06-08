using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Allergies",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImplantedDevice",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImplantedDeviceDetails",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LatexSensitive",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalLegalCase",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pregnant",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Smoke",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkRestriction",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allergies",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "ImplantedDevice",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "ImplantedDeviceDetails",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "LatexSensitive",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "MedicalLegalCase",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "Pregnant",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "Smoke",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "WorkRestriction",
                table: "MedicalIntakes");
        }
    }
}
