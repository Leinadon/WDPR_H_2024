using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_OurUsers_SpecialistID",
                table: "Guardians");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_OurUsers_SpecialistID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys",
                column: "SpecialistId",
                principalTable: "OurUsers",
                principalColumn: "TempId2",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_OurUsers_SpecialistID",
                table: "Guardians");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_OurUsers_SpecialistID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_OurUsers_SpecialistID",
                table: "Answers",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId2",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disabilitys_OurUsers_SpecialistId",
                table: "Disabilitys",
                column: "SpecialistId",
                principalTable: "OurUsers",
                principalColumn: "TempId3",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guardians_OurUsers_SpecialistID",
                table: "Guardians",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId4",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_OurUsers_SpecialistID",
                table: "Locations",
                column: "SpecialistID",
                principalTable: "OurUsers",
                principalColumn: "TempId5");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User1ID",
                table: "OurChats",
                column: "User1ID",
                principalTable: "OurUsers",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_User2ID",
                table: "OurChats",
                column: "User2ID",
                principalTable: "OurUsers",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
