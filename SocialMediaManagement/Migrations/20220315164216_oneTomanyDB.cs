using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMediaManagement.Migrations
{
    public partial class oneTomanyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuItemItemID",
                table: "MenuItemActions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupID",
                table: "Users",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemActions_MenuItemItemID",
                table: "MenuItemActions",
                column: "MenuItemItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemActions_MenuItems_MenuItemItemID",
                table: "MenuItemActions",
                column: "MenuItemItemID",
                principalTable: "MenuItems",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupID",
                table: "Users",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemActions_MenuItems_MenuItemItemID",
                table: "MenuItemActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_MenuItemActions_MenuItemItemID",
                table: "MenuItemActions");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MenuItemItemID",
                table: "MenuItemActions");
        }
    }
}
