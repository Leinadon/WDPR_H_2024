using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsForRelationsImprovement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_DoesResearches_DoesResearchID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Specialists_SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilities_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Companys_CompanyID",
                schema: "MyCustomSchema",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineAssignmentResults_OnlineAssignments_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_User1ID",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_User2ID",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Interviews_InterviewId",
                schema: "MyCustomSchema",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Questionnaires_QuestionnaireId",
                schema: "MyCustomSchema",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Interviews",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "OnlineAssignments",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Questionnaires",
                schema: "MyCustomSchema");

            migrationBuilder.DropTable(
                name: "Specialists",
                schema: "MyCustomSchema");

            migrationBuilder.DropIndex(
                name: "IX_Questions_InterviewId",
                schema: "MyCustomSchema",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionnaireId",
                schema: "MyCustomSchema",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_OurChats_User1ID",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_OurChats_User2ID",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_OnlineAssignmentResults_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CompanyID",
                schema: "MyCustomSchema",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_DoesResearches_SpecialistId",
                schema: "MyCustomSchema",
                table: "DoesResearches");

            migrationBuilder.DropIndex(
                name: "IX_Disabilities_SpecialistId",
                schema: "MyCustomSchema",
                table: "Disabilities");

            migrationBuilder.DropIndex(
                name: "IX_Answers_SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "MyCustomSchema",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                schema: "MyCustomSchema",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Guardians");

            migrationBuilder.AddColumn<int>(
                name: "disabilityTypeId",
                schema: "MyCustomSchema",
                table: "Researches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "User2ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "User1ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "LocationId",
                schema: "MyCustomSchema",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_DoesResearches_DoesResearchID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "DoesResearchID",
                principalSchema: "MyCustomSchema",
                principalTable: "DoesResearches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "QuestionID",
                principalSchema: "MyCustomSchema",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_Users_UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_Users_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId1",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_DoesResearches_DoesResearchID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                schema: "MyCustomSchema",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_OurChats_UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_OurChats_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "disabilityTypeId",
                schema: "MyCustomSchema",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "MyCustomSchema",
                table: "Companys");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "MyCustomSchema",
                table: "Researches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "User2ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "User1ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                schema: "MyCustomSchema",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AlterColumn<string>(
                name: "SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Interviews",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Interviews_Researches_ID",
                        column: x => x.ID,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Researches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineAssignments",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Researches_ID",
                        column: x => x.ID,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Researches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                schema: "MyCustomSchema",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuardianID = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ApproachCommercialParties = table.Column<bool>(type: "bit", nullable: false),
                    DisabilityNote = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    MessagePreference = table.Column<int>(type: "int", nullable: false),
                    ToolsUsing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialists_Guardians_GuardianID",
                        column: x => x.GuardianID,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Guardians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialists_Locations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialists_Users_Id",
                        column: x => x.Id,
                        principalSchema: "MyCustomSchema",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_InterviewId",
                schema: "MyCustomSchema",
                table: "Questions",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionnaireId",
                schema: "MyCustomSchema",
                table: "Questions",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_User1ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "User1ID");

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_User2ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "User2ID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineAssignmentResults_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults",
                column: "OnlineAssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CompanyID",
                schema: "MyCustomSchema",
                table: "Locations",
                column: "CompanyID",
                unique: true,
                filter: "[CompanyID] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "SpecialistID");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_GuardianID",
                schema: "MyCustomSchema",
                table: "Specialists",
                column: "GuardianID",
                unique: true,
                filter: "[GuardianID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_LocationId",
                schema: "MyCustomSchema",
                table: "Specialists",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_DoesResearches_DoesResearchID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "DoesResearchID",
                principalSchema: "MyCustomSchema",
                principalTable: "DoesResearches",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "QuestionID",
                principalSchema: "MyCustomSchema",
                principalTable: "Questions",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Specialists_SpecialistID",
                schema: "MyCustomSchema",
                table: "Answers",
                column: "SpecialistID",
                principalSchema: "MyCustomSchema",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Companys_CompanyID",
                schema: "MyCustomSchema",
                table: "Locations",
                column: "CompanyID",
                principalSchema: "MyCustomSchema",
                principalTable: "Companys",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineAssignmentResults_OnlineAssignments_OnlineAssignmentID",
                schema: "MyCustomSchema",
                table: "OnlineAssignmentResults",
                column: "OnlineAssignmentID",
                principalSchema: "MyCustomSchema",
                principalTable: "OnlineAssignments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_Users_User1ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "User1ID",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_Users_User2ID",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "User2ID",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Interviews_InterviewId",
                schema: "MyCustomSchema",
                table: "Questions",
                column: "InterviewId",
                principalSchema: "MyCustomSchema",
                principalTable: "Interviews",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Questionnaires_QuestionnaireId",
                schema: "MyCustomSchema",
                table: "Questions",
                column: "QuestionnaireId",
                principalSchema: "MyCustomSchema",
                principalTable: "Questionnaires",
                principalColumn: "ID");
        }
    }
}
