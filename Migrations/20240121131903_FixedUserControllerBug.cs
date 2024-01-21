using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPR.Migrations
{
    /// <inheritdoc />
    public partial class FixedUserControllerBug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_Id",
                schema: "MyCustomSchema",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_Users_SenderUserId",
                schema: "MyCustomSchema",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_Users_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_Users_Id",
                schema: "MyCustomSchema",
                table: "Specialists");

            // migrationBuilder.DropForeignKey(
            //     name: "FK_Users_AspNetUsers_Id",
            //     schema: "MyCustomSchema",
            //     table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "MyCustomSchema",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "MyCustomSchema",
                newName: "OurUsers",
                newSchema: "MyCustomSchema");

            migrationBuilder.AlterColumn<string>(
                name: "idenitityUserId",
                schema: "MyCustomSchema",
                table: "OurUsers",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OurUsers",
                schema: "MyCustomSchema",
                table: "OurUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_OurUsers_Id",
                schema: "MyCustomSchema",
                table: "Employees",
                column: "Id",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_OurUsers_SenderUserId",
                schema: "MyCustomSchema",
                table: "OurChatMessages",
                column: "SenderUserId",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OurUsers_AspNetUsers_Id",
                schema: "MyCustomSchema",
                table: "OurUsers",
                column: "idenitityUserId",
                principalSchema: "MyCustomSchema",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_OurUsers_Id",
                schema: "MyCustomSchema",
                table: "Specialists",
                column: "Id",
                principalSchema: "MyCustomSchema",
                principalTable: "OurUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_OurUsers_Id",
                schema: "MyCustomSchema",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChatMessages_OurUsers_SenderUserId",
                schema: "MyCustomSchema",
                table: "OurChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_UserId",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurChats_OurUsers_UserId1",
                schema: "MyCustomSchema",
                table: "OurChats");

            migrationBuilder.DropForeignKey(
                name: "FK_OurUsers_AspNetUsers_Id",
                schema: "MyCustomSchema",
                table: "OurUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_OurUsers_Id",
                schema: "MyCustomSchema",
                table: "Specialists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OurUsers",
                schema: "MyCustomSchema",
                table: "OurUsers");

            migrationBuilder.RenameTable(
                name: "OurUsers",
                schema: "MyCustomSchema",
                newName: "Users",
                newSchema: "MyCustomSchema");

            migrationBuilder.AlterColumn<string>(
                name: "idenitityUserId",
                schema: "MyCustomSchema",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "MyCustomSchema",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_Id",
                schema: "MyCustomSchema",
                table: "Employees",
                column: "Id",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurChatMessages_Users_SenderUserId",
                schema: "MyCustomSchema",
                table: "OurChatMessages",
                column: "SenderUserId",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_Users_Id",
                schema: "MyCustomSchema",
                table: "Specialists",
                column: "Id",
                principalSchema: "MyCustomSchema",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AspNetUsers_Id",
                schema: "MyCustomSchema",
                table: "Users",
                column: "Id",
                principalSchema: "MyCustomSchema",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
