using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    public partial class splittedResearches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disability_AspNetUsers_SpecialistId",
                table: "Disability");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                table: "Disability",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Disability",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sector",
                table: "Companies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    ResearchId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Reward = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: true),
                    ResearchType = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: true),
                    Explanation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.ResearchId);
                    table.ForeignKey(
                        name: "FK_Researches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    QuestionnaireResearchId = table.Column<int>(type: "INTEGER", nullable: true),
                    InterviewResearchId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Question_Researches_InterviewResearchId",
                        column: x => x.InterviewResearchId,
                        principalTable: "Researches",
                        principalColumn: "ResearchId");
                    table.ForeignKey(
                        name: "FK_Question_Researches_QuestionnaireResearchId",
                        column: x => x.QuestionnaireResearchId,
                        principalTable: "Researches",
                        principalColumn: "ResearchId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_InterviewResearchId",
                table: "Question",
                column: "InterviewResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionnaireResearchId",
                table: "Question",
                column: "QuestionnaireResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_Researches_CompanyId",
                table: "Researches",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disability_AspNetUsers_SpecialistId",
                table: "Disability",
                column: "SpecialistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disability_AspNetUsers_SpecialistId",
                table: "Disability");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Disability");

            migrationBuilder.DropColumn(
                name: "Sector",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistId",
                table: "Disability",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    QuestionnaireId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationDate = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.QuestionnaireId);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_CompanyId",
                table: "Questionnaires",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disability_AspNetUsers_SpecialistId",
                table: "Disability",
                column: "SpecialistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
