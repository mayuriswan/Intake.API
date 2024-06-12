using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ConfigTable",
                columns: new[] { "Id", "Email", "EmailBody" },
                values: new object[] { 1, "admin@example.com", "<p>Your intake form has been successfully submitted. Thank you!</p>" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigTable");
        }
    }
}
