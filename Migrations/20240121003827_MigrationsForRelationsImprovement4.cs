using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsForRelationsImprovement4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnlineAssignments",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineAssignments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OnlineAssignments_Researches_ID",
                        column: x => x.ID,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Researches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineAssignmentResults_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults",
                column: "OnlineAssignmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineAssignmentResults_OnlineAssignments_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults",
                column: "OnlineAssignmentID",
                principalSchema: "MyCustomSchema",
                principalTable: "OnlineAssignments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineAssignmentResults_OnlineAssignments_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults");

            migrationBuilder.DropTable(
                name: "OnlineAssignments",
                schema: "MyCustomSchema");

            migrationBuilder.DropIndex(
                name: "IX_OnlineAssignmentResults_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults");
        }
    }
}
