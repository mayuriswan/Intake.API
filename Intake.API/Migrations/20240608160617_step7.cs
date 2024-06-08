using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BloodThinningMedications",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SteroidMedications",
                table: "MedicalIntakes",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MedConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntakeReference = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedConditions_MedicalIntakes_IntakeReference",
                        column: x => x.IntakeReference,
                        principalTable: "MedicalIntakes",
                        principalColumn: "ReferenceNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefMedConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefMedConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefSugConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSugConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SugConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntakeReference = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SugConditions_MedicalIntakes_IntakeReference",
                        column: x => x.IntakeReference,
                        principalTable: "MedicalIntakes",
                        principalColumn: "ReferenceNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RefMedConditions",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Hypertension", true },
                    { 2, "Diabetes", true },
                    { 3, "Asthma", true },
                    { 4, "Allergies", true },
                    { 5, "Arthritis", true }
                });

            migrationBuilder.InsertData(
                table: "RefSugConditions",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Appendectomy", true },
                    { 2, "Gallbladder Removal", true },
                    { 3, "Hernia Repair", true },
                    { 4, "Cataract Surgery", true },
                    { 5, "Joint Replacement", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedConditions_IntakeReference",
                table: "MedConditions",
                column: "IntakeReference");

            migrationBuilder.CreateIndex(
                name: "IX_SugConditions_IntakeReference",
                table: "SugConditions",
                column: "IntakeReference");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedConditions");

            migrationBuilder.DropTable(
                name: "RefMedConditions");

            migrationBuilder.DropTable(
                name: "RefSugConditions");

            migrationBuilder.DropTable(
                name: "SugConditions");

            migrationBuilder.DropColumn(
                name: "BloodThinningMedications",
                table: "MedicalIntakes");

            migrationBuilder.DropColumn(
                name: "SteroidMedications",
                table: "MedicalIntakes");
        }
    }
}
