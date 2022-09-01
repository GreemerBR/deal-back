using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class CreateTableCategoriesAndUpdateAllTheOthers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteAnnounce_AnunId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropColumn(
                name: "AnunCat",
                table: "Announce");

            migrationBuilder.AddColumn<int>(
                name: "AnnounceId",
                table: "FavoriteAnnounce",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Announce",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAnnounce_AnnounceId",
                table: "FavoriteAnnounce",
                column: "AnnounceId");

            migrationBuilder.CreateIndex(
                name: "IX_Announce_CategoriesId",
                table: "Announce",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announce_Categorie_CategoriesId",
                table: "Announce",
                column: "CategoriesId",
                principalTable: "Categorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce",
                column: "AnnounceId",
                principalTable: "Announce",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announce_Categorie_CategoriesId",
                table: "Announce");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnnounceId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteAnnounce_AnnounceId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropIndex(
                name: "IX_Announce_CategoriesId",
                table: "Announce");

            migrationBuilder.DropColumn(
                name: "AnnounceId",
                table: "FavoriteAnnounce");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Announce");

            migrationBuilder.AddColumn<string>(
                name: "AnunCat",
                table: "Announce",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAnnounce_AnunId",
                table: "FavoriteAnnounce",
                column: "AnunId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAnnounce_Announce_AnunId",
                table: "FavoriteAnnounce",
                column: "AnunId",
                principalTable: "Announce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
