using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateAnnouncesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnunCep",
                table: "Announce");

            migrationBuilder.DropColumn(
                name: "AnunEndereco",
                table: "Announce");

            migrationBuilder.DropColumn(
                name: "AnunImage1",
                table: "Announce");

            migrationBuilder.DropColumn(
                name: "AnunImage2",
                table: "Announce");

            migrationBuilder.RenameColumn(
                name: "AnunImage3",
                table: "Announce",
                newName: "AnunImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnunImage",
                table: "Announce",
                newName: "AnunImage3");

            migrationBuilder.AddColumn<string>(
                name: "AnunCep",
                table: "Announce",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnunEndereco",
                table: "Announce",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "AnunImage1",
                table: "Announce",
                type: "BYTEA",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "AnunImage2",
                table: "Announce",
                type: "BYTEA",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
