using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudLivros.Migrations
{
    /// <inheritdoc />
    public partial class Addnovosdados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "altura",
                table: "Livros",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ano",
                table: "Livros",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "autor",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "edicao",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "editora",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "largura",
                table: "Livros",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "profundidade",
                table: "Livros",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "altura",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "ano",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "autor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "categoria",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "edicao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "editora",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "largura",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "profundidade",
                table: "Livros");
        }
    }
}
