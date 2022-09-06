using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AlterTableFavoriteAnnounces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropColumn(
                name: "AnunId",
                table: "FavoriteAnnounce");

            migrationBuilder.AlterColumn<int>(
                name: "AnnounceId",
                table: "FavoriteAnnounce",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce",
                column: "AnnounceId",
                principalTable: "Announce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce");

            migrationBuilder.AlterColumn<int>(
                name: "AnnounceId",
                table: "FavoriteAnnounce",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "AnunId",
                table: "FavoriteAnnounce",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce",
                column: "AnnounceId",
                principalTable: "Announce",
                principalColumn: "Id");
        }
    }
}
