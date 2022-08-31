using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class CreateTableAnnunce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnunTitulo = table.Column<string>(type: "text", nullable: false),
                    AnunDescri = table.Column<string>(type: "text", nullable: false),
                    AnunCat = table.Column<string>(type: "text", nullable: false),
                    AnunCep = table.Column<string>(type: "text", nullable: false),
                    AnunEndereco = table.Column<string>(type: "text", nullable: false),
                    AnunData = table.Column<string>(type: "text", nullable: false),
                    AnunValor = table.Column<decimal>(type: "numeric", nullable: false),
                    AnunImage1 = table.Column<byte[]>(type: "BYTEA", nullable: false),
                    AnunImage2 = table.Column<byte[]>(type: "BYTEA", nullable: false),
                    AnunImage3 = table.Column<byte[]>(type: "BYTEA", nullable: false),
                    UserIdId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announce_User_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announce_UserIdId",
                table: "Announce",
                column: "UserIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announce");
        }
    }
}
