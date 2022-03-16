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
                name: "ItemID",
                table: "MenuItemActions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupID",
                table: "Users",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemActions_ItemID",
                table: "MenuItemActions",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemActions_MenuItems_ItemID",
                table: "MenuItemActions",
                column: "ItemID",
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
                name: "FK_MenuItemActions_MenuItems_ItemID",
                table: "MenuItemActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_MenuItemActions_ItemID",
                table: "MenuItemActions");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "MenuItemActions");
        }
    }
}
