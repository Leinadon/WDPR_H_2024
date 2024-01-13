using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class initialcreateAzure3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Disabilities",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "OnlineAssignmentResults",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "OurChatMessages",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Questions",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "DisabilityTypes",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "OnlineAssignments",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "OurChats",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Interviews",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Questionnaires",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "DoesResearches",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Researches",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Specialists",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Guardians",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Companys",
                schema: "MyCustomSchema");
        }
    }
}
