using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMediaManagement.Migrations
{
    public partial class manyTomanyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupIActionRelations",
                columns: table => new
                {
                    GroupIActionRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    ItemActionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupIActionRelations", x => x.GroupIActionRelationID);
                    table.ForeignKey(
                        name: "FK_GroupIActionRelations_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupIActionRelations_MenuItemActions_ItemActionID",
                        column: x => x.ItemActionID,
                        principalTable: "MenuItemActions",
                        principalColumn: "ItemActionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupItemRelations",
                columns: table => new
                {
                    GroupMenuItemRelationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupItemRelations", x => x.GroupMenuItemRelationId);
                    table.ForeignKey(
                        name: "FK_GroupItemRelations_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupItemRelations_MenuItems_ItemID",
                        column: x => x.ItemID,
                        principalTable: "MenuItems",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupIActionRelations_GroupID",
                table: "GroupIActionRelations",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupIActionRelations_ItemActionID",
                table: "GroupIActionRelations",
                column: "ItemActionID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupItemRelations_GroupID",
                table: "GroupItemRelations",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupItemRelations_ItemID",
                table: "GroupItemRelations",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupIActionRelations");

            migrationBuilder.DropTable(
                name: "GroupItemRelations");
        }
    }
}
