using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsForRelationsImprovement3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
