using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiagnosedConditions",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RefDiagnosedConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefDiagnosedConditions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RefDiagnosedConditions",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Bladder/Urinary Tract Infection", true },
                    { 2, "Cancer", true },
                    { 3, "Circulation Problems", true },
                    { 4, "Depression", true },
                    { 5, "Eye Problem/infection", true },
                    { 6, "Hepatitis", true },
                    { 7, "Liver Problems", true },
                    { 8, "No Prone Lying", true },
                    { 9, "Other Arthritic Conditions", true },
                    { 10, "Psoriasis", true },
                    { 11, "Spina Bifida", true },
                    { 12, "Tuberculosis", true },
                    { 13, "Anemia", true },
                    { 14, "Asthma", true },
                    { 15, "Blood Clots", true },
                    { 16, "Bone or Joint Infection", true },
                    { 17, "Chemical Dependency (i.e., alcoholism)", true },
                    { 18, "Chest Pain/Angina", true },
                    { 19, "Costochondritis", true },
                    { 20, "CostoChronditis", true },
                    { 21, "Diabetes", true },
                    { 22, "Epilepsy", true },
                    { 23, "Fibromyalgia", true },
                    { 24, "Heart Problems", true },
                    { 25, "High Blood Pressure", true },
                    { 26, "Kidney Problem/Infection", true },
                    { 27, "Lung Problems", true },
                    { 28, "Multiple Sclerosis", true },
                    { 29, "No Supine Lying", true },
                    { 30, "Osteoporosis", true },
                    { 31, "Pelvic Inflammatory Disease", true },
                    { 32, "Pneumonia", true },
                    { 33, "Rheumatoid Arthritis", true },
                    { 34, "Sexually Transmitted Disease/HIV", true },
                    { 35, "Stroke", true },
                    { 36, "Thyroid Problems", true },
                    { 37, "Ulcers", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefDiagnosedConditions");

            migrationBuilder.DropColumn(
                name: "DiagnosedConditions",
                table: "MedicalIntakes");
        }
    }
}
