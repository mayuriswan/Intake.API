using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "MedicalIntakes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_MedicalIntakes_ReferenceNumber",
                table: "MedicalIntakes",
                column: "ReferenceNumber");

            migrationBuilder.CreateTable(
                name: "MedBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntakeReference = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BodyPart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedBodyParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedBodyParts_MedicalIntakes_IntakeReference",
                        column: x => x.IntakeReference,
                        principalTable: "MedicalIntakes",
                        principalColumn: "ReferenceNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefBodyParts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RefBodyParts",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Right Arm", true },
                    { 2, "Left Arm", true },
                    { 3, "Right Knee", true },
                    { 4, "Left Knee", true },
                    { 5, "Head", true },
                    { 6, "Neck", true },
                    { 7, "Right Foot", true },
                    { 8, "Left Foot", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedBodyParts_IntakeReference",
                table: "MedBodyParts",
                column: "IntakeReference");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedBodyParts");

            migrationBuilder.DropTable(
                name: "RefBodyParts");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_MedicalIntakes_ReferenceNumber",
                table: "MedicalIntakes");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
