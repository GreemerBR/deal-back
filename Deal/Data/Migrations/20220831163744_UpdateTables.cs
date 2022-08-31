using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announce_User_UserIdId",
                table: "Announce");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunIdId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_User_UserIdId",
                table: "FavoriteAnnounce");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "FavoriteAnnounce",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AnunIdId",
                table: "FavoriteAnnounce",
                newName: "AnunId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAnnounce_UserIdId",
                table: "FavoriteAnnounce",
                newName: "IX_FavoriteAnnounce_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAnnounce_AnunIdId",
                table: "FavoriteAnnounce",
                newName: "IX_FavoriteAnnounce_AnunId");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Announce",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Announce_UserIdId",
                table: "Announce",
                newName: "IX_Announce_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announce_User_UserId",
                table: "Announce",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunId",
                table: "FavoriteAnnounce",
                column: "AnunId",
                principalTable: "Announce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_User_UserId",
                table: "FavoriteAnnounce",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announce_User_UserId",
                table: "Announce");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_User_UserId",
                table: "FavoriteAnnounce");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FavoriteAnnounce",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "AnunId",
                table: "FavoriteAnnounce",
                newName: "AnunIdId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAnnounce_UserId",
                table: "FavoriteAnnounce",
                newName: "IX_FavoriteAnnounce_UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAnnounce_AnunId",
                table: "FavoriteAnnounce",
                newName: "IX_FavoriteAnnounce_AnunIdId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Announce",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Announce_UserId",
                table: "Announce",
                newName: "IX_Announce_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announce_User_UserIdId",
                table: "Announce",
                column: "UserIdId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunIdId",
                table: "FavoriteAnnounce",
                column: "AnunIdId",
                principalTable: "Announce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_User_UserIdId",
                table: "FavoriteAnnounce",
                column: "UserIdId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
