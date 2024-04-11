using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudLivros.Migrations
{
    /// <inheritdoc />
    public partial class CrudLivros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qtdPag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sinapse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codBarras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
