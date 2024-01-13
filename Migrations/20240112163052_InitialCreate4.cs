using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId1",
                table: "DoesResearches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_OurUsers_SpecialistID",
                table: "Guardians");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_OurUsers_SpecialistID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurChats_OurChatID",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_DoesResearches_DoesResearchInt",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_Researches_Companys_CompanyId",
                table: "Researches");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_Guardians_GuardianID",
                table: "Specialists");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_Locations_LocationId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_GuardianID",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_LocationId",
                table: "Specialists");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId1",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId2",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId3",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId4",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurUsers_TempId5",
                table: "OurUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OurChats_TempId",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_OurChats_DoesResearchInt",
                table: "OurChats");

            migrationBuilder.DropIndex(
                name: "IX_Locations_SpecialistID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Guardians_SpecialistID",
                table: "Guardians");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DoesResearches_TempId",
                table: "DoesResearches");

            migrationBuilder.DropIndex(
                name: "IX_DoesResearches_SpecialistId1",
                table: "DoesResearches");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId1",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId2",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId3",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId4",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId5",
                table: "OurUsers");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "SpecialistId1",
                table: "DoesResearches");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Specialists",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "OurChats",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OurChatMessages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "TempId",
                table: "DoesResearches",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_GuardianID",
                table: "Specialists",
                column: "GuardianID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_LocationId",
                table: "Specialists",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoesResearches_ChatId",
                table: "DoesResearches",
                column: "ChatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoesResearches_SpecialistId",
                table: "DoesResearches",
                column: "SpecialistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Specialists_SpecialistID",
                table: "Answers",
                column: "SpecialistID",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys",
                column: "DisabilityTypeId",
                principalTable: "DisabilityTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_Specialists_SpecialistId",
                table: "Disabilitys",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_DoesResearches_OurChats_ChatId",
                table: "DoesResearches",
                column: "ChatId",
                principalTable: "OurChats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                table: "DoesResearches",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurChats_OurChatID",
                table: "OurChatMessages",
                column: "OurChatID",
                principalTable: "OurChats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages",
                column: "Id",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats",
                column: "User1ID",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats",
                column: "User2ID",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Researches_Companys_CompanyId",
                table: "Researches",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_Guardians_GuardianID",
                table: "Specialists",
                column: "GuardianID",
                principalTable: "Guardians",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_Locations_LocationId",
                table: "Specialists",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Specialists_SpecialistID",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_Specialists_SpecialistId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_OurChats_ChatId",
                table: "DoesResearches");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                table: "DoesResearches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurChats_OurChatID",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_Researches_Companys_CompanyId",
                table: "Researches");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_Guardians_GuardianID",
                table: "Specialists");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_Locations_LocationId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_GuardianID",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_LocationId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_DoesResearches_ChatId",
                table: "DoesResearches");

            migrationBuilder.DropIndex(
                name: "IX_DoesResearches_SpecialistId",
                table: "DoesResearches");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Specialists",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OurUsers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId1",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId2",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId3",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId4",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId5",
                table: "OurUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "OurChats",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "OurChats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OurChatMessages",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "TempId",
                table: "DoesResearches",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialistId1",
                table: "DoesResearches",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId",
                table: "OurUsers",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId1",
                table: "OurUsers",
                column: "TempId1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId2",
                table: "OurUsers",
                column: "TempId2");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId3",
                table: "OurUsers",
                column: "TempId3");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId4",
                table: "OurUsers",
                column: "TempId4");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurUsers_TempId5",
                table: "OurUsers",
                column: "TempId5");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OurChats_TempId",
                table: "OurChats",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DoesResearches_TempId",
                table: "DoesResearches",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_GuardianID",
                table: "Specialists",
                column: "GuardianID");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_LocationId",
                table: "Specialists",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_DoesResearchInt",
                table: "OurChats",
                column: "DoesResearchInt");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_SpecialistID",
                table: "Locations",
                column: "SpecialistID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_SpecialistID",
                table: "Guardians",
                column: "SpecialistID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoesResearches_SpecialistId1",
                table: "DoesResearches",
                column: "SpecialistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys",
                column: "DisabilityTypeId",
                principalTable: "DisabilityTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys",
                column: "SpecialistId",
                principalTable: "OurUsers",
                principalColumn: "TempId2",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId1",
                table: "DoesResearches",
                column: "SpecialistId1",
                principalTable: "Specialists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guardians_OurUsers_SpecialistID",
                table: "Guardians",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId3",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_OurUsers_SpecialistID",
                table: "Locations",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId4");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurChats_OurChatID",
                table: "OurChatMessages",
                column: "OurChatID",
                principalTable: "OurChats",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages",
                column: "Id",
                principalTable: "OurUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_DoesResearches_DoesResearchInt",
                table: "OurChats",
                column: "DoesResearchInt",
                principalTable: "DoesResearches",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats",
                column: "User1ID",
                principalTable: "OurUsers",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats",
                column: "User2ID",
                principalTable: "OurUsers",
                principalColumn: "TempId5",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Researches_Companys_CompanyId",
                table: "Researches",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_Guardians_GuardianID",
                table: "Specialists",
                column: "GuardianID",
                principalTable: "Guardians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_Locations_LocationId",
                table: "Specialists",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
