using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsForRelationsImprovement2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Specialists",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ToolsUsing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessagePreference = table.Column<int>(type: "int", nullable: false),
                    DisabilityNote = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ApproachCommercialParties = table.Column<bool>(type: "bit", nullable: false),
                    TrackingID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialists_Users_Id",
                        column: x => x.Id,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoesResearches_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_Disabilities_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities",
                column: "SpecialistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilities_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities",
                column: "SpecialistId",
                principalSchema: "MyCustomSchema",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches",
                column: "SpecialistId",
                principalSchema: "MyCustomSchema",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disabilities_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches");

            migrationBuilder.DropTable(
                name: "Specialists",
                schema: "MyCustomSchema");

            migrationBuilder.DropIndex(
                name: "IX_DoesResearches_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches");

            migrationBuilder.DropIndex(
                name: "IX_Disabilities_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
