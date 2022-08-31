using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateTableAnnunces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announce_User_UserId",
                table: "Announce");

            migrationBuilder.DropIndex(
                name: "IX_Announce_UserId",
                table: "Announce");

            migrationBuilder.AlterColumn<double>(
                name: "AnunValor",
                table: "Announce",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AnunValor",
                table: "Announce",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
    }
}
