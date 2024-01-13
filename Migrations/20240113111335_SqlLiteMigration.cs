using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class SqlLiteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_DoesResearches_ChatId",
                table: "DoesResearches");

            migrationBuilder.DropColumn(
                name: "DoesResearchInt",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "DoesResearches");

            migrationBuilder.AddColumn<int>(
                name: "DoesResearchID",
                table: "OurChats",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OurChats_DoesResearchID",
                table: "OurChats",
                column: "DoesResearchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys",
                column: "DisabilityTypeId",
                principalTable: "DisabilityTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_Specialists_SpecialistId",
                table: "Disabilitys",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                table: "DoesResearches",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages",
                column: "Id",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_DoesResearches_DoesResearchID",
                table: "OurChats",
                column: "DoesResearchID",
                principalTable: "DoesResearches",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats",
                column: "User1ID",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats",
                column: "User2ID",
                principalTable: "OurUsers",
                principalColumn: "Id",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_DisabilityTypes_DisabilityTypeId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_Specialists_SpecialistId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_DoesResearches_Specialists_SpecialistId",
                table: "DoesResearches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companys_CompanyId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurUsers_Id",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_DoesResearches_DoesResearchID",
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
                name: "IX_OurChats_DoesResearchID",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "DoesResearchID",
                table: "OurChats");

            migrationBuilder.AddColumn<string>(
                name: "DoesResearchInt",
                table: "OurChats",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "DoesResearches",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoesResearches_ChatId",
                table: "DoesResearches",
                column: "ChatId",
                unique: true);

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
    }
}
