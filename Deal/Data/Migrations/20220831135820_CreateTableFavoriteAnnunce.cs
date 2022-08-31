using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class CreateTableFavoriteAnnunce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteAnnounce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserIdId = table.Column<int>(type: "integer", nullable: false),
                    AnunIdId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteAnnounce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteAnnounce_Announce_AnunIdId",
                        column: x => x.AnunIdId,
                        principalTable: "Announce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteAnnounce_User_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAnnounce_AnunIdId",
                table: "FavoriteAnnounce",
                column: "AnunIdId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAnnounce_UserIdId",
                table: "FavoriteAnnounce",
                column: "UserIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteAnnounce");
        }
    }
}
