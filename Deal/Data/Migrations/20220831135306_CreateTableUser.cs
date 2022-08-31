using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class CreateTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserNomeCompleto = table.Column<string>(type: "text", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    UserSenha = table.Column<string>(type: "text", nullable: false),
                    UserApelido = table.Column<string>(type: "text", nullable: true),
                    UserCpf = table.Column<string>(type: "text", nullable: true),
                    UserTelefone = table.Column<string>(type: "text", nullable: true),
                    UserCep = table.Column<string>(type: "text", nullable: true),
                    UserEstado = table.Column<string>(type: "text", nullable: true),
                    UserCidade = table.Column<string>(type: "text", nullable: true),
                    UserBairro = table.Column<string>(type: "text", nullable: true),
                    UserRua = table.Column<string>(type: "text", nullable: true),
                    UserComplemento = table.Column<string>(type: "text", nullable: true),
                    UserNumero = table.Column<int>(type: "integer", nullable: true),
                    UserImage = table.Column<byte[]>(type: "BYTEA", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
