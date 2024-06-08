using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intake.API.Migrations
{
    /// <inheritdoc />
    public partial class step31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecentlyNoted",
                table: "MedicalIntakes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecentlyNoted",
                table: "MedicalIntakes");
        }
    }
}
