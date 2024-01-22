using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class FixedFKResearchToDisbillityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "disabilityTypeId",
                schema: "MyCustomSchema",
                table: "Researches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "disabilityTypeId",
                schema: "MyCustomSchema",
                table: "Researches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
