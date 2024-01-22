using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class FixedFKChatInDoesResearch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropColumn(
                name: "ChatId",
                schema: "MyCustomSchema",
                table: "DoesResearches");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "OurUserId1");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "OurUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OurChats_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "IX_OurChats_OurUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_OurChats_UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "IX_OurChats_OurUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_OurUserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "OurUserId",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_OurUserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "OurUserId1",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_OurUserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_OurUserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.RenameColumn(
                name: "OurUserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "OurUserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OurChats_OurUserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "IX_OurChats_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_OurChats_OurUserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                newName: "IX_OurChats_UserId");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                schema: "MyCustomSchema",
                table: "DoesResearches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_UserId",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OurChats_OurUsers_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats",
                column: "UserId1",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id");
        }
    }
}
