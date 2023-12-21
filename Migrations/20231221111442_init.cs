using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "StreetName",
                table: "Companies",
                newName: "Location_StreetName");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Companies",
                newName: "Location_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Companies",
                newName: "Location_Place");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "Companies",
                newName: "Location_HouseNumber");

            migrationBuilder.RenameColumn(
                name: "CustomProperty",
                table: "AspNetUsers",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "SenderUserId",
                table: "ChatMessages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ApproachCommercialParties",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisabilityNote",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GuardianId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_HouseNumber",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_Place",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_PostalCode",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_StreetName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessagePreference",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToolsUsing",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackingID",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Disability",
                columns: table => new
                {
                    DisabilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpecialistId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disability", x => x.DisabilityId);
                    table.ForeignKey(
                        name: "FK_Disability_AspNetUsers_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Guardian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardian", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_SenderUserId",
                table: "ChatMessages",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChatId",
                table: "AspNetUsers",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GuardianId",
                table: "AspNetUsers",
                column: "GuardianId");

            migrationBuilder.CreateIndex(
                name: "IX_Disability_SpecialistId",
                table: "Disability",
                column: "SpecialistId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Chats_ChatId",
                table: "AspNetUsers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Guardian_GuardianId",
                table: "AspNetUsers",
                column: "GuardianId",
                principalTable: "Guardian",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_AspNetUsers_SenderUserId",
                table: "ChatMessages",
                column: "SenderUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Chats_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Guardian_GuardianId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_AspNetUsers_SenderUserId",
                table: "ChatMessages");

            migrationBuilder.DropTable(
                name: "Disability");

            migrationBuilder.DropTable(
                name: "Guardian");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_SenderUserId",
                table: "ChatMessages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GuardianId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SenderUserId",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "ApproachCommercialParties",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DisabilityNote",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GuardianId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_HouseNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_Place",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_StreetName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MessagePreference",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ToolsUsing",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TrackingID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Location_StreetName",
                table: "Companies",
                newName: "StreetName");

            migrationBuilder.RenameColumn(
                name: "Location_PostalCode",
                table: "Companies",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Location_Place",
                table: "Companies",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "Location_HouseNumber",
                table: "Companies",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "AspNetUsers",
                newName: "CustomProperty");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Companies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
