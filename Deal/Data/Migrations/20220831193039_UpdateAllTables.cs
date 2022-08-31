using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Announce_UserId",
                table: "Announce",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announce_User_UserId",
                table: "Announce",
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

            migrationBuilder.DropIndex(
                name: "IX_Announce_UserId",
                table: "Announce");
        }
    }
}
